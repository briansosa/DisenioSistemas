FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
COPY *.csproj ./app/Bridge/
WORKDIR /app/Bridge
RUN dotnet restore

COPY . ./Bridge/
RUN dotnet publish -o out /p:PublishWithAspNetCoreTargetManifest="false"

FROM mcr.microsoft.com/dotnet/runtime:5.0 AS runtime
ENV ASPNETCORE_URLS http://+:80
WORKDIR /app
COPY --from=build /app/Bridge/out ./
ENTRYPOINT ["dotnet", "Bridge.dll"]