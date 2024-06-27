FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine3.19-amd64 as builder
WORKDIR /opt/app
EXPOSE 80
EXPOSE 443

COPY chefstock-platform/*.csproj ./
RUN dotnet restore

COPY chefstock-platform/ .
RUN dotnet publish -c Release -o out -r linux-musl-x64 --no-self-contained

FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine3.19-amd64 as runner
ENV ASPNETCORE_ENVIRONMENT="Production"

WORKDIR /opt/app

RUN apk add --no-cache fontconfig
COPY --from=builder /opt/app/out .

ENTRYPOINT ["dotnet", "chefstock-platform.dll"]