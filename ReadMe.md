
The Amadeus SDK for C# .NET makes it easy for developers to access Amadeus Self-Service APIs in their .NET Project code, and build travel applications using services like Air (Flight search and Inteliigence), Hotel (Hotel search and offers) and Destination(Point of interest). You can get started in minutes by installing the SDK through NuGet.

## Step 1: Set up your account
The first step to start using Amadeus Self-Service APIs is to register and create an account:

In the top right corner of the page, click on register
Complete the form, using a valid email address and click on the Create account button. An automatic confirmation email will be sent to the email address you registered
In the confirmation email you receive, click on Confirm my account
You can now log in to the portal with your new credentials! Welcome to Amadeus for Developers! 

## Step 2: Get your API key
To start using the APIs you need to tell the system that you are allowed to do so. This process is called authentication.

All you need to do is to attach an alphanumeric string called token to your calls. This token will identify you as valid user and is generated from two parameters: API Key and API Secret.

## Step 3: Create project and add SDK

Use the Nuget Package: AmadeusSdk


## Example Code:

```csharp
string client_id = "<<CLIENT_ID>>";
string client_secret = "<<CLIENT_SECRET>>";

//Generate access token usually valid for 1800 sec
AuthClient authClient = new AuthClient(client_id, client_secret);
var token = authClient.GenerateAccessToken();

// Get token info to check expiry before generating another token
token = authClient.GetTokenInfo(token.AccessToken);

if(token.ExpiresIn > 0)
{
    HotelClient hotelClient = new HotelClient(token.AccessToken);
    var hotelSearch = hotelClient.HotelSearch.GetMultiHotelOffersAsync("LON").Result;
}
```
