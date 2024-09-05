docker network rm threetenant

docker network create threetenant
docker-compose -f docker-compose.infrastructure.yml up -d

docker logs -f mssqlDb_container
