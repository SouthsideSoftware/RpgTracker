#!/bin/bash
LOCAL_RAVENDB_DATA="${RPGTRACKER_RAVENDB_DATA:-$HOME/RavenDB}"
docker run --rm -d -p 8080:8080 -p 38888:38888 -v "$LOCAL_RAVENDB_DATA":/opt/RavenDB/Server/RavenData --name RavenRpgTracker -e RAVEN_Setup_Mode=None -e RAVEN_License_Eula_Accepted=true -e RAVEN_Security_UnsecuredAccessAllowed=PrivateNetwork ravendb/ravendb