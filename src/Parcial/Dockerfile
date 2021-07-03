FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
COPY *.csproj ./app/Parcial/
WORKDIR /app/Parcial
RUN dotnet restore

COPY . ./Parcial/
RUN dotnet publish -o out /p:PublishWithAspNetCoreTargetManifest="false"

FROM mcr.microsoft.com/dotnet/runtime:5.0 AS runtime
ENV ASPNETCORE_URLS http://+:80
WORKDIR /app
COPY --from=build /app/Parcial/out ./
ENTRYPOINT ["dotnet", "Parcial.dll"]