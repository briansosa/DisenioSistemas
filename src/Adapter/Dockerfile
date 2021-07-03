FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
COPY *.csproj ./app/Adapter/
WORKDIR /app/Adapter
RUN dotnet restore

COPY . ./Adapter/
RUN dotnet publish -o out /p:PublishWithAspNetCoreTargetManifest="false"

FROM mcr.microsoft.com/dotnet/runtime:5.0 AS runtime
ENV ASPNETCORE_URLS http://+:80
WORKDIR /app
COPY --from=build /app/Adapter/out ./
ENTRYPOINT ["dotnet", "Adapter.dll"]