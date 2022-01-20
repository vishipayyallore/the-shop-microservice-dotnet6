# Few Point on Catalog API

**File:** launchSettings.json

```
"Docker": {
      "commandName": "Docker",
      "launchBrowser": true,
      "launchUrl": "{Scheme}://{ServiceHost}:{ServicePort}/swagger",
      "publishAllPorts": true,
      "environmentVariables": {
        "DatabaseSettings__ConnectionString": "mongodb://172.17.0.3:27017"
      }
    }
```
To Retrieve the IP Address of the MongoDB Container, run the following command:
```
docker inspect --format '{{ .NetworkSettings.IPAddress }}' mongodb
```
![Docker Inspect For IP](../images/Docker_Inspect_For_IP.PNG)

## Few Docker commands
```
docker pull mongo
docker run -d -p 27017:27017 --name shop-mongo mongo
docker ps
docker logs -f shop-mongo
docker exec -it shop-mongo /bin/bash
```

## Few Mongo commands

```
mongo
show dbs
```

```
use catalogDb;
db.createCollection('Products');
```


```
db.Products.insertMany([{ 'Name':'Asus Laptop','Category':'Computers', 'Summary':'Summary', 'Description':'Description', 'ImageFile':'ImageFile', 'Price':54.93 }, { 'Name':'HP Laptop','Category':'Computers', 'Summary':'Summary', 'Description':'Description', 'ImageFile':'ImageFile', 'Price':88.93 } ])

db.Products.find({}).pretty()

db.Products.remove({})

show databases

show collections

db.Products.find({}).pretty()
```