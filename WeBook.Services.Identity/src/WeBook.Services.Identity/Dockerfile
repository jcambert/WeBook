#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["WeBook.Services.Identity/WeBook.Services.Identity.csproj", "WeBook.Services.Identity/"]
RUN dotnet restore "WeBook.Services.Identity/WeBook.Services.Identity.csproj"
COPY . .
WORKDIR "/src/WeBook.Services.Identity"
RUN dotnet build "WeBook.Services.Identity.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WeBook.Services.Identity.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WeBook.Services.Identity.dll"]