FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base

WORKDIR /app

EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build

# Setup NodeJs
RUN apt-get -qq update && \
    apt-get -qq install -y wget && \
    apt-get -qq install -y gnupg2 && \
    wget -qO- https://deb.nodesource.com/setup_10.x | bash - && \
    apt-get -qq install -y build-essential nodejs && \
    apt-get -qq install -y nginx
# End setup

WORKDIR /src
COPY ["api/api.csproj", "src/api/"]
COPY ["application/application.csproj", "src/application/"]
COPY ["domain/domain.csproj", "src/domain/"]
COPY ["infrastructure/infrastructure.csproj", "src/infrastructure/"]
COPY ["persistence/persistence.csproj", "src/persistence/"]

COPY . .
WORKDIR "/src/api"

RUN dotnet build "api.csproj" -c Release -o /app

FROM build AS publish

RUN dotnet publish "api.csproj" -c Release -o /app

COPY ["client-app/", "/app/client-app"]

RUN cd /app/client-app \
    && npm install && npm run build && mv build ../

RUN mv /app/build /app/wwwroot/

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "API.dll"]
