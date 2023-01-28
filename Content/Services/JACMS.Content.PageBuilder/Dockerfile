#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["JACMS.Content.PageBuilder/JACMS.Content.PageBuilder.csproj", "JACMS.Content.PageBuilder/"]
RUN dotnet restore "JACMS.Content.PageBuilder/JACMS.Content.PageBuilder.csproj"
COPY . .
WORKDIR "/src/JACMS.Content.PageBuilder"
RUN dotnet build "JACMS.Content.PageBuilder.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "JACMS.Content.PageBuilder.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "JACMS.Content.PageBuilder.dll"]