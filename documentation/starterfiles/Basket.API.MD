# Few Point on Basket API

## Few Docker commands
```
docker pull redis
docker run -d -p 6379:6379 --name shop-redis redis
docker ps
docker logs -f shop-redis
docker exec -it shop-redis /bin/bash
```

## Few Mongo commands

```
redis-cli
ping - PONG
```

```
root@85d8a88e01e2:/data# redis-cli
127.0.0.1:6379> ping
PONG
127.0.0.1:6379> exit
```

```
set key value
get key
set name User1
get name
```
