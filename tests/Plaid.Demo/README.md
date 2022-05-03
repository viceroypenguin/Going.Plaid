# Plaid Demo

Let’s test out running Plaid locally by running the Demo. You’ll need API keys, which you can receive by signing up in the [Plaid Dashboard](https://dashboard.plaid.com/team/keys).

You'll have two different API keys, and there are three different Plaid environments. Today we'll start in the Sandbox environment. View the API Keys section of the [Dashboard](https://dashboard.plaid.com/team/keys) to find your Sandbox secret.

Create a `secrets.json` file in the project root directory to contain your API keys. This file will be excluded from source control, so you needn't worry about leaking your credentials in your pull requests!

```json
{
	"Plaid": {
		"ClientID": "*** YOUR CLIENT ID ***",
		"Secret": "*** YOUR SANDBOX SECRET ***"
	}
}
```
