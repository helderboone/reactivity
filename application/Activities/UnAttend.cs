﻿using Application.Errors;
using Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Activities
{
    public class UnAttend 
    {
        public class Command : IRequest
        {
            public Guid Id{ get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            private readonly IUserAccessor _userAccessor;

            public Handler(DataContext context, IUserAccessor userAccessor)
            {
                _context = context;
                _userAccessor = userAccessor;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var activity = await _context.Activities.FindAsync(request.Id);

                if (activity == null) throw new RestException(HttpStatusCode.NotFound, new { Activity = "Could not find activity" });

                var user = await _context.Users.SingleOrDefaultAsync(x => x.UserName == _userAccessor.GetCurrentUserName());

                var attendance = await _context.UserActivities.SingleOrDefaultAsync(x => x.ActivityId == activity.Id && x.AppUserId == user.Id);

                if (attendance == null) return Unit.Value;

                if (attendance.IsHost) throw new RestException(HttpStatusCode.BadRequest, new { Attendence = "You cannot remove yourself as host" });

                _context.UserActivities.Remove(attendance);

                var success = await _context.SaveChangesAsync() > 0;

                if (!success) throw new Exception("Problem saving changes");

                return Unit.Value;
            }
        }
    }
}
