# RpgTracker

The ambition is to build a tool for managing encounters and characters.

## Managing RavenDB

RavenDB is a NoSQL database used for storage and search. It runs in a Docker container and stores data in a local folder stored
in the envrionment variable RPGTRACKER_RAVENDB_DATA. if this environment variable is not set, it will default to 
~/RavenDB. This directory will be created automatically at first startup.

Please note that this setup is designed for use on your local development machine. It is using the community version 
of RavenDB without encryption or logon security so it is not suitable for production.

To start:

````
sudo scripts/startRaven.sh
````

To stop:

````
sudo scripts/startRaven.sh
````

To force an update to the latest version of RavenDB on next start:

````
sudo scripts/deleteRavenImage.sh
````