FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app

EXPOSE 7264
EXPOSE 5229


## 1 stage - building frontend
FROM node:21-alpine as angular-app

WORKDIR /frontend

COPY src/frontend/package*.json .

RUN npm install

COPY src/frontend/ .

RUN npm run build --prod
# Built application is in /src/dist


FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /backend
COPY src/backend/Directory.Build.props .
COPY src/backend/CloudTunes.API/CloudTunes.API.csproj CloudTunes.API/
COPY src/backend/CloudTunes.Core/CloudTunes.Core.csproj CloudTunes.Core/
COPY src/backend/CloudTunes.Infrastructure/CloudTunes.Infrastructure.csproj CloudTunes.Infrastructure/
RUN dotnet restore "./CloudTunes.API/CloudTunes.API.csproj"
COPY src/backend/ .
WORKDIR "/backend/CloudTunes.API"
RUN dotnet build -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY --from=angular-app /frontend/dist ./wwwroot
ENTRYPOINT ["dotnet", "CloudTunes.API.dll"]
