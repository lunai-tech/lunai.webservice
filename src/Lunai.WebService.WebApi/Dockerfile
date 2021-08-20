#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/Lunai.WebService.WebApi/Lunai.WebService.WebApi.csproj", "src/Lunai.WebService.WebApi/"]
RUN dotnet restore "src/Lunai.WebService.WebApi/Lunai.WebService.WebApi.csproj"
COPY . .
WORKDIR "/src/src/Lunai.WebService.WebApi"
RUN dotnet build "Lunai.WebService.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Lunai.WebService.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Lunai.WebService.WebApi.dll"]