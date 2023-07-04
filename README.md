# E-Commerce .NET Core Web API

This is a .NET Core Web API project designed for an E-Commerce application. It provides two APIs for listing products and getting product details by ID.


## Table of Contents

- [Overview](#overview)
- [Getting Started](#getting-started)
- [API Endpoints](#api-endpoints)

## Overview

The E-Commerce .NET Core Web API I is built,using the Onion Architecture and follows the Repository Pattern for data access, to serve as the backend for an online store. It provides endpoints to retrieve a list of products and get detailed information about individual products.

## Getting Started

### Prerequisites

- .NET 6 SDK
- PostgreSQL database

### Installation

1. Clone the repository:
   ```shell
   git clone https://github.com/your/repository.git
2. Update connection string in appsettings.json
3. Project uses entity framwork code first approach so in the project path run add-migration then update-database to get db.

## API Endpoints
### List Products
Endpoint: /api/products
Method: GET
Description: Retrieves a list of products available in the store.
Response: A JSON array containing product details, including name, price, description, etc.
### Get Product by ID
Endpoint: /api/products/{id}
Method: GET
Description: Retrieves detailed information about a specific product based on its unique ID.
Response: A JSON object containing the product's details.


