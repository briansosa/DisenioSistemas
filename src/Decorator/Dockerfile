FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
COPY *.csproj ./app/Decorator/
WORKDIR /app/Decorator
RUN dotnet restore

COPY . ./Decorator/
RUN dotnet publish -o out /p:PublishWithAspNetCoreTargetManifest="false"

FROM mcr.microsoft.com/dotnet/runtime:5.0 AS runtime
ENV ASPNETCORE_URLS http://+:80
WORKDIR /app
COPY --from=build /app/Decorator/out ./
ENTRYPOINT ["dotnet", "Decorator.dll"]