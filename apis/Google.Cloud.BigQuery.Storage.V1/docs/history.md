# Version history

## Version 2.9.0, released 2022-04-04

### New features

- Deprecate format specific `row_count` field in Read API ([commit 682ee9e](https://github.com/googleapis/google-cloud-dotnet/commit/682ee9e031905a71c664234e6901de88438d7556))

## Version 2.8.0, released 2022-03-14

### New features

- Update default timeout/retry information ([commit e64637d](https://github.com/googleapis/google-cloud-dotnet/commit/e64637d6ed0544c3fe2981560a8ea8c8a5532364))
- Update parent annotation for BatchCommitWriteStreamsRequest ([commit e64637d](https://github.com/googleapis/google-cloud-dotnet/commit/e64637d6ed0544c3fe2981560a8ea8c8a5532364))
- Expose additional StorageError enum values ([commit e64637d](https://github.com/googleapis/google-cloud-dotnet/commit/e64637d6ed0544c3fe2981560a8ea8c8a5532364))

### Documentation improvements

- Improve documentation for write client ([commit e64637d](https://github.com/googleapis/google-cloud-dotnet/commit/e64637d6ed0544c3fe2981560a8ea8c8a5532364))

## Version 2.7.0, released 2022-02-22

### New features

- Add trace_id for Read API ([commit 2cac347](https://github.com/googleapis/google-cloud-dotnet/commit/2cac34761c11e939b6150fb70fd4409f40c7edb8))

### Additional notes

- The `bigquery.readonly` auth scope has been removed has been removed from the default scope set ([commit f691c91](https://github.com/googleapis/google-cloud-dotnet/commit/f691c9119d6b00f1c0629a5d5bc65c7b6ee8ed12)). We don't expect that to break any users, but please be aware of the change.


## Version 2.6.0, released 2022-01-17

### New features

- Add write_mode support for BigQuery Storage Write API v1 ([commit 129c391](https://github.com/googleapis/google-cloud-dotnet/commit/129c391394ff748a5f9ae34cd0ee68acf4acc421))

## Version 2.5.0, released 2021-09-24

- [Commit d200346](https://github.com/googleapis/google-cloud-dotnet/commit/d200346): fix: add missing read api retry setting on SplitReadStream
- [Commit c896df1](https://github.com/googleapis/google-cloud-dotnet/commit/c896df1): feat: add BigQuery Storage Write API v1
- [Commit beebb6a](https://github.com/googleapis/google-cloud-dotnet/commit/beebb6a):
  - docs: Align session length with public documentation
  - feat: Expose estimated bytes that a session will scan.

## Version 2.4.0, released 2021-08-19

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 2.3.0, released 2021-06-22

- [Commit 72f542b](https://github.com/googleapis/google-cloud-dotnet/commit/72f542b): feat: Add ZSTD compression as an option for Arrow.

## Version 2.2.0, released 2021-04-14

- [Commit 9f5f0aa](https://github.com/googleapis/google-cloud-dotnet/commit/9f5f0aa): Regenerate server-streaming calls with Google request params. Fixes [issue 6310](https://github.com/googleapis/google-cloud-dotnet/issues/6310).
- [Commit 10a22c9](https://github.com/googleapis/google-cloud-dotnet/commit/10a22c9):
  - feat: add a Arrow compression options (Only LZ4 for now).
  - feat: Return schema on first ReadRowsResponse. doc: clarify limit on filter string.

## Version 2.1.0, released 2020-10-08

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation
- [Commit 062f39c](https://github.com/googleapis/google-cloud-dotnet/commit/062f39c): docs: Update an out-of-date external link.
- [Commit 5632dbd](https://github.com/googleapis/google-cloud-dotnet/commit/5632dbd): docs: Comment fix

## Version 2.0.0, released 2020-03-17

No API surface changes compared with 2.0.0-beta01, just dependency,
comment and implementation changes.

## Version 2.0.0-beta01, released 2020-02-17

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

## Version 1.0.0-beta01, released 2020-02-11

Initial beta release.
