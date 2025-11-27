# LogEntryQuery

Represents a query for logs

**Properties**

| Name      | Type                                                | Required | Description                                                                                                                                                 |
| :-------- | :-------------------------------------------------- | :------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------- |
| EndTime   | string                                              | ✅       | The end time of the time range                                                                                                                              |
| Query     | string                                              | ✅       | The query string for filtering logs                                                                                                                         |
| StartTime | string                                              | ✅       | The start time of the time range                                                                                                                            |
| PageSize  | long                                                | ❌       | The maximum number of items per page.                                                                                                                       |
| SortOrder | [LogEntryQuerySortOrder](LogEntryQuerySortOrder.md) | ❌       | The sort order of the log entries. `asc` will sort the log entries in chronological order. `desc` will sort the log entries in reverse chronological order. |
