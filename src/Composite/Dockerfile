FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
COPY *.csproj ./app/Composite/
WORKDIR /app/Composite
RUN dotnet restore

COPY . ./Composite/
RUN dotnet publish -o out /p:PublishWithAspNetCoreTargetManifest="false"

FROM mcr.microsoft.com/dotnet/runtime:5.0 AS runtime
ENV ASPNETCORE_URLS http://+:80
WORKDIR /app
COPY --from=build /app/Composite/out ./
ENTRYPOINT ["dotnet", "Composite.dll"]