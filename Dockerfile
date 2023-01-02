FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

COPY ["Api/Api.csproj", "Api/"]
COPY ["Application/Application.csproj", "Application/"]
COPY ["Domain/Domain.csproj", "Domain/"]
COPY ["Infra/Infra.csproj", "Infra/"]

COPY . ./
WORKDIR /app
RUN dotnet build "Api/Api.csproj" -c Release -o app/build
RUN dotnet build "Application/Application.csproj" -c Release -o app/build
RUN dotnet build "Domain/Domain.csproj" -c Release -o app/build
RUN dotnet build "Infra/Infra.csproj" -c Release -o app/build

RUN dotnet restore

FROM build AS publish
RUN dotnet publish "Api.csproj" -c Release -o /app/publish
RUN dotnet publish "Application.csproj" -c Release -o /app/publish
RUN dotnet publish "Domain.csproj" -c Release -o /app/publish
RUN dotnet publish "Infra.csproj" -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0 as runtime
WORKDIR /app
COPY --from=build /app/publish-app /app
ENTRYPOINT ["dotnet", "/Api/Api.dll"]