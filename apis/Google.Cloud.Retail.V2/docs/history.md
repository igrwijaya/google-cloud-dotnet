# Version history

## Version 1.6.0, released 2022-04-04

### New features

- Add new AddLocalInventories and RemoveLocalInventories APIs ([commit 0af0e7a](https://github.com/googleapis/google-cloud-dotnet/commit/0af0e7ab415cdb807645c0f30121011fb289352f))
- Users cannot switch to empty default branch unless force override ([commit 0af0e7a](https://github.com/googleapis/google-cloud-dotnet/commit/0af0e7ab415cdb807645c0f30121011fb289352f))
- Allow search users to skip validation for invalid boost specs ([commit 0af0e7a](https://github.com/googleapis/google-cloud-dotnet/commit/0af0e7ab415cdb807645c0f30121011fb289352f))
- Support search personalization ([commit 0af0e7a](https://github.com/googleapis/google-cloud-dotnet/commit/0af0e7ab415cdb807645c0f30121011fb289352f))
- Search returns applied control ids in the response ([commit 0af0e7a](https://github.com/googleapis/google-cloud-dotnet/commit/0af0e7ab415cdb807645c0f30121011fb289352f))

### Documentation improvements

- Users can self enroll retail search feature on cloud console ([commit 0af0e7a](https://github.com/googleapis/google-cloud-dotnet/commit/0af0e7ab415cdb807645c0f30121011fb289352f))
- Suggest search users not to send IP and use hashed user id ([commit 0af0e7a](https://github.com/googleapis/google-cloud-dotnet/commit/0af0e7ab415cdb807645c0f30121011fb289352f))
- Deprecate request_id in ImportProductsRequest ([commit 0af0e7a](https://github.com/googleapis/google-cloud-dotnet/commit/0af0e7ab415cdb807645c0f30121011fb289352f))
- Deprecate search dynamic_facet_spec and suggest to config on cloud console ([commit 0af0e7a](https://github.com/googleapis/google-cloud-dotnet/commit/0af0e7ab415cdb807645c0f30121011fb289352f))
- Keep the API doc up-to-date with recent changes ([commit 0af0e7a](https://github.com/googleapis/google-cloud-dotnet/commit/0af0e7ab415cdb807645c0f30121011fb289352f))

## Version 1.5.0, released 2021-12-07

- [Commit 2925818](https://github.com/googleapis/google-cloud-dotnet/commit/2925818):
  - docs: Keep the API doc up-to-date
  - feat: update grpc service config settings to reflect correct API deadlines
- [Commit deb7506](https://github.com/googleapis/google-cloud-dotnet/commit/deb7506): docs: fix docstring formatting
## Version 1.4.0, released 2021-10-20

- [Commit 3c5e164](https://github.com/googleapis/google-cloud-dotnet/commit/3c5e164):
  - docs: Keep the API doc up-to-date
  - feat: add search mode to search request. If not specified, a single search request triggers both product search and faceted search.
  - feat: update grpc service config settings to reflect correct API deadlines

## Version 1.3.0, released 2021-09-23

- [Commit 672325d](https://github.com/googleapis/google-cloud-dotnet/commit/672325d):
  - docs: Keep the API doc up-to-date
  - feat: update grpc service config settings to reflect correct API deadlines
  - chore: remove relative private links from search service comments to prevent crashing client lib generation tool
- [Commit 51b50d0](https://github.com/googleapis/google-cloud-dotnet/commit/51b50d0): docs: Keep the API doc up-to-date
- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.2.0, released 2021-08-10

- [Commit 130477c](https://github.com/googleapis/google-cloud-dotnet/commit/130477c): docs(retail): Quote several literal expressions for better rendering
- [Commit e5f12af](https://github.com/googleapis/google-cloud-dotnet/commit/e5f12af): docs: Remove HTML tags from Cloud Retail API library docs
- [Commit 30871b2](https://github.com/googleapis/google-cloud-dotnet/commit/30871b2): docs: remove remaining private links
- [Commit 360c029](https://github.com/googleapis/google-cloud-dotnet/commit/360c029): feat: Add restricted Retail Search features for Retail API v2.

## Version 1.1.0, released 2021-04-29

- [Commit 91fa8df](https://github.com/googleapis/google-cloud-dotnet/commit/91fa8df): docs: Put resource paths in code spans and use absolute URLs

Note: no API surface changes, but still a minor version bump due to dependency updates.

## Version 1.0.0, released 2021-01-20

No API changes since 1.0.0-beta01.

## Version 1.0.0-beta01, released 2020-12-15

Initial release, for customers in the early access programme.
