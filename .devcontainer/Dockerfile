# Use the official image as a parent image
FROM mcr.microsoft.com/dotnet/sdk:6.0

# Change the default shell to bash
SHELL ["/bin/bash", "-c"]

# Install necessary dependencies
RUN apt-get update && export DEBIAN_FRONTEND=noninteractive \
    && apt-get -y install --no-install-recommends gnupg lsb-release unzip curl

# Install Node.js
RUN curl -sL https://deb.nodesource.com/setup_14.x | bash -
RUN apt-get install -y nodejs

# Verify Node.js and npm installation
RUN node --version
RUN npm --version

# Install Angular CLI
RUN npm install -g @angular/cli@12

# Install SQL Tools: SQLPackage and sqlcmd
COPY mssql/installSQLtools.sh installSQLtools.sh
RUN bash ./installSQLtools.sh \
    && apt-get clean -y && rm -rf /var/lib/apt/lists/* /tmp/library-scripts

# Install Entity Framework
RUN dotnet tool install --global dotnet-ef --version 7.0.0
ENV PATH="$PATH:/root/.dotnet/tools"
RUN dotnet ef --version

