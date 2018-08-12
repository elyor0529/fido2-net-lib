# fido2-net-lib
A proof of Concept implementation library + demo for fido2 and WebAuthn using .NET (Work in progress)

To run the demo: Start Fido2Demo (SSL, expected url https://localhost:44329) and open https://localhost:44329/index.html in the browser.

If you want to have a look at the code, the most interesting is these files for now:

* [Controller.cs](https://github.com/abergs/fido2-net-lib/blob/master/Fido2Demo/Controller.cs)
* [Fido2NetLib.cs](https://github.com/abergs/fido2-net-lib/blob/master/fido2-net-lib/Fido2NetLib.cs)
* [AuthenticatorAttestationResponse.cs](https://github.com/abergs/fido2-net-lib/blob/master/fido2-net-lib/AuthenticatorAttestationResponse.cs)

The HTML and javascript is copied (more or less as-is) from WebAuthn.io.

Feedback, issues and pull requests are VERY welcome.


## Supported features

✅ Attestation API & verification (Register and verify credentials/authenticators)
✅ Assertment API & verification (Authenticate users)
✅ Fido 2 Security Keys
✅ Backwards compatability with Fido-u2f.
❔ Windows Hello support
✅ ES256 Public Key format (no other public key formats yet)
✅ "none", "fidu-u2f" & "packed" attestation formats
❌ "tpm", "android-key", "android-safetynet"

## Examples

Coming soon

## Nuget package

Coming when lib has matured.