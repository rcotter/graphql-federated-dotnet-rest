Use GraphQL Federation to stitch subgraphs, each from their own respective domain service, into
a single cohesive graph. Each domain service maintains and publishes its own description.
A gateway service brings them altogether as a single entry point for the clients to 
interact with.

# Running
## Companies Service
1. Run `CompaniesService`. 
2. Go to http://localhost:4001/api/companies to see RESTfully served JSON.
3. Go to http://localhost:4001/graphql/ and run queries in the Operations tab:
    1. Try getting all companies:
       ```graphql
       {
         companies {
           id
           name              
         }
       }
       ```
    2. Get a single company (adding in address and aliasing street):
       ```graphql
       {
         companyById(id: 1) {
           id
           name 
           address {
             st: street
             number
           }             
         }
       } 
       ```
       
## Products Service
1. Run `ProductsService`
2. Go to http://localhost:4002/api/products to see RESTfully served JSON.
3. Go to http://localhost:4002/graphql/ and run queries in the Operations tab:
    1. Get all products:
       ```graphql
       {
         products {
           id
           name        
           companyId      
         }
       }
       ```
    2. Get a single company:
       ```graphql
       {
         productById(id: 1) {
           id
           name 
           companyId             
         }
       } 
       ```

## Stitch Them Together
Notice that products have references to companies. If our app needs to work with a company's products
two REST or two GraphQL calls are required and then some painful merging of the two responses.

Happily we can use GraphQL Federation and its stitching. As a client we can get what we want without
any knowledge of the multiple underlying services. Our gateway brings it all together using our
capabilities and references that domain services publish. The gateway code does not
maintain its own knowledge of how to stitch domain responses together.

1. Run `GraphqlGateway`
2. Go to http://localhost:4000/graphql/ and run queries in the Operations tab:
    1. Get all companies with their products
       ```graphql
       {
         companies {
           id
           name
           address {
             street
             number
           }
           products {
             id
             name
           }
         }
       }
       ```
    2. Get a single company with its products
       ```graphql
       {
         companyById(id: 1) {
           id
           name
           address {
             street
             number
           }
           products {
             id
             name
           }
         }
       }
       ```

# Implementation
GraphQL was setup as per [HotChocolate](https://chillicream.com/docs/hotchocolate/v12/get-started-with-graphql-in-net-core).

