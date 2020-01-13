using Application.Interfaces;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Photos
{
    public class Add
    {
        public class Command : IRequest<Photo>
        {
            public IFormFile File{ get; set; }            
        }

        public class Handler : IRequestHandler<Command, Photo>
        {
            private readonly DataContext _context;
            private readonly IUserAccessor _userAccessor;
            private readonly IPhotoAccessor _photoAccesor;

            public Handler(DataContext context, IUserAccessor userAccessor, IPhotoAccessor photoAccesor)
            {
                _context = context;
                _userAccessor = userAccessor;
                _photoAccesor = photoAccesor;
            }

            public async Task<Photo> Handle(Command request, CancellationToken cancellationToken)
            {
                var photoUploadResult = _photoAccesor.AddPhoto(request.File);

                var user = await _context.Users.SingleOrDefaultAsync(x => x.UserName == _userAccessor.GetCurrentUserName());

                var photo = new Photo
                {
                    Url = photoUploadResult.Url,
                    Id = photoUploadResult.PublicId
                };

                if (!user.Photos.Any(x => x.IsMain))
                    photo.IsMain = true;

                user.Photos.Add(photo);

                var success = await _context.SaveChangesAsync() > 0;

                if (!success) throw new Exception("Problem saving changes");

                return photo;
            }
        }
    }
}
