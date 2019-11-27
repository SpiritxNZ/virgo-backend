# Virgo.Backend.Repository
This project contains the database models and commonly used logic.

#### Run database locally
`docker run -p 46985:3306 --name=virgo -e MYSQL_ROOT_HOST=% -e MYSQL_ROOT_PASSWORD=my-secret-pw -d mysql/mysql-server:latest`

#### EF Migrations Tables MYSQL

Current state of MySQL EF .NET Core driver doesnt automatically scaffold the migrations history table.
The below sql command will need to be run in order to setup the initial table for migrations to work.

```SQL
CREATE TABLE __EFMigrationsHistory (
    MigrationId nvarchar(150) NOT NULL,
    ProductVersion nvarchar(32) NOT NULL,
    CONSTRAINT PK_HistoryRow PRIMARY KEY (MigrationId));
```