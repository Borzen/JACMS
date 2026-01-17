#!/usr/bin/env bash

SQL_DIR="/docker-entrypoint-initdb.d/SQLScripts"

set -e

echo "Creating Schemas"
psql -d "$POSTGRES_DB" --username "$POSTGRES_USER" -f $SQL_DIR/00_CreateSchemas.sql

for f in "$SQL_DIR"/Identity/*.sql
do
	echo "Running $f"
	psql -d "$POSTGRES_DB" --username "$POSTGRES_USER" -f "$f"
done