using Firebase.Auth;
using Firebase.Auth.Providers;

// Configure...
var config = new FirebaseAuthConfig
{
    ApiKey = "<YOUR_API_KEY>",
    AuthDomain = "<Auth domain>",
    Providers = new FirebaseAuthProvider[]
    {
        // Add and configure individual providers
        new GoogleProvider().AddScopes("email"),
        new EmailProvider()
    }
};

// ...and create your FirebaseAuthClient
var client = new FirebaseAuthClient(config);
var user = await client.SignInAnonymouslyAsync();

// sign up or sign in with email and password
// var userCredential = await client.CreateUserWithEmailAndPasswordAsync("email", "pwd", "Display Name");
// var userCredential = await client.SignInWithEmailAndPasswordAsync("email", "pwd");

// sign in via provider specific AuthCredential
// var credential = TwitterProvider.GetCredential("access_token", "oauth_token_secret");
// var credential = GoogleProvider.GetCredential("id_token", "access_token");
// var userCredential = await client.SignInWithCredentialAsync(credential);

/*
// sign in via web browser redirect - navigate to given uri, monitor a redirect to 
// your authdomain.firebaseapp.com/__/auth/handler
// and return the whole redirect uri back to the client;
// this method is actually used by FirebaseUI
var userCredential = await client.SignInWithRedirectAsync(provider, async uri =>
{    
    return await OpenBrowserAndWaitForRedirectToAuthDomain(uri);
});
*/