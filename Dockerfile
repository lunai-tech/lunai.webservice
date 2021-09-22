FROM mcr.microsoft.com/dotnet/sdk:5.0-alpine AS build
WORKDIR /app 
#
# copy csproj and restore as distinct layers
COPY *.sln .
COPY /src/Lunai.WebService.WebApi/*.csproj ./src/Lunai.WebService.WebApi/
COPY /src/Lunai.WebService.Application/*.csproj ./src/Lunai.WebService.Application/
COPY /src/Lunai.WebService.Domain/*.csproj ./src/Lunai.WebService.Domain/
COPY /src/Lunai.WebService.Infrastructure.Data.MongoDB/*.csproj ./src/Lunai.WebService.Infrastructure.Data.MongoDB/
#
RUN dotnet restore 
#
# copy everything else and build app
COPY /src/Lunai.WebService.WebApi/. ./src/Lunai.WebService.WebApi/
COPY /src/Lunai.WebService.Application/. ./src/Lunai.WebService.Application/
COPY /src/Lunai.WebService.Domain/. ./src/Lunai.WebService.Domain/
COPY /src/Lunai.WebService.Infrastructure.Data.MongoDB/. ./src/Lunai.WebService.Infrastructure.Data.MongoDB/
#
WORKDIR /app/src/Lunai.WebService.WebApi
RUN dotnet publish -c Release -o out 
#
FROM mcr.microsoft.com/dotnet/aspnet:5.0-alpine AS runtime
WORKDIR /app 
#
COPY --from=build /app/src/Lunai.WebService.WebApi/out ./
ENTRYPOINT ["dotnet", "Lunai.WebService.WebApi.dll"]