# LogEntryCollection

Represents a page of organization logs

**Properties**

| Name             | Type           | Required | Description                                                                      |
| :--------------- | :------------- | :------- | :------------------------------------------------------------------------------- |
| Items            | List<LogEntry> | ✅       | A collection of log entries                                                      |
| OrganizationName | string         | ✅       | The organization name.                                                           |
| PageMaxTime      | string         | ✅       | The maximum time page boundary. This may be used when getting paginated results. |
| PageMinTime      | string         | ✅       | The minimum time page boundary. This may be used when getting paginated results. |
