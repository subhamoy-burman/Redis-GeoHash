# RedisGeoHashDemo

## Overview

This project demonstrates how to use Redis GeoHash for efficient geospatial indexing and querying in a C# console application. The application adds geospatial data (latitude and longitude) to Redis, queries for nearby businesses within a specified radius, and sorts the results by distance.

## Prerequisites

- Windows 10/11 with WSL2 enabled
- Ubuntu installed via WSL
- Redis installed on Ubuntu
- Visual Studio 2019 or later
- .NET Core SDK

## Installation

### Step 1: Install Redis on Windows using WSL

1. **Enable WSL2**:
   Open PowerShell as Administrator and run the following command:
   ```shell
   wsl --install
   sudo apt update
   sudo apt install redis-server

### Step 2: Start Redis Server

1. sudo service redis-server start

### Step 3: Install Redis

Install-Package StackExchange.Redis -Version 2.8.24

