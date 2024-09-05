docker-compose -f docker-compose.migrator.yml up -d
docker logs -f threetenantmigrator_container
docker container rm threetenantmigrator_container