# Reactivity

![Preview-Screens](https://github.com/helderboone/reactivity/blob/master/reactivity-layout.jpeg)

## About this Project

The idea of the App is:

_"Social network application that allows users to sign up to events (similar to MeetUp or Facebook)
"._

Why?
This project is a result from course at [udemy.com](https://www.udemy.com/course/complete-guide-to-building-an-app-with-net-core-and-react/)

The author: Neil Cummings

Email-me: helder.boone@gmail.com

Connect with me at [LinkedIn](https://www.linkedin.com/in/helder-boone-493a7784).

That project is to study and improve skills in Asp Net Core and React Mobx.

## Functionalities

- Login/Register
	- Create a user and Loggin

- Follow/Following
	- Like instagram you may want to follow and be followed

- Profile 
	- Can select a profile picture
    - Select main picture profile
    - Edit your bio
    - List activities in the past and future

- Activities
    - Create a new activity
    - Attend an activity
    - Manage the activity
    - Real time chat in the activity


## Getting Started

### Prerequisites

To run this project in the development mode, you'll need to have a basic environment to run a React App, that can be found [here](https://create-react-app.dev/docs/getting-started/).

Also, you'll need to the server running locally on your machine with the mock data. You can find the server and all the instructions to start the server with .NET Core SDK 3.1 installed.

### Installing

**Cloning the Repository**

```
$ git clone https://github.com/helderboone/reactivity.git

$ cd reactivity
```

**Installing dependencies**

```
$ cd reactivity && dotnet build
```

```
$ cd api && dotnet watch run
```

_or_

```
$ dotnet run -p api/
```

```
$ cd client-app && yarn
```

_or_

```
$ $ cd client-app && npm install
```

## Docker support
    Make sure both docker engine and docker-compose are installed

```
$ git clone https://github.com/helderboone/reactivity.git

$ cd reactivity

$ docker-compose up -d
```
	
## Built with

### Backend
- [NET Core 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1) - Install .NET Core 3.1 
- [Asp Net Core SignalR](https://docs.microsoft.com/pt-br/aspnet/core/signalr/introduction?view=aspnetcore-3.1) - Introduction to Asp Net Core SignalR 
- [MediatR](https://github.com/jbogard/MediatR) - MediatR
- [AutoMapper](https://automapper.org/) - AutoMapper
- [EntityFrameworkCore](https://docs.microsoft.com/pt-br/ef/core/) - EntityFramework Core 3.1
- [Identity](https://docs.microsoft.com/pt-br/aspnet/core/security/authentication/customize-identity-model?view=aspnetcore-3.1) - Identity


### Frontend
- [React](https://create-react-app.dev/docs/getting-started/) - Create React app
- [MobX](https://mobx.js.org/README.html/) - React State Manager
- [Axios](https://github.com/axios/axios) - HTTP Client
- [ESlint](https://eslint.org/) - Linter
- [Prettier](https://prettier.io/) - Code Formatter
- [Babel](https://babeljs.io/) - JavaScript Compiler
- [Semantic-UI](https://react.semantic-ui.com/) - Styles

## Support tools

- [cloudinary](https://cloudinary.com/) - Store the Images

## Contributing

Can send as many PR's as you want, I'll be glad to analyse and accept them! And if you have any question about the project...

Email-me: helder.boone@gmail.com

Thank you!