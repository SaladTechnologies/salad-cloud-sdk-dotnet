# NewRelicLoggingConfiguration

Configuration for sending container logs to New Relic's log management platform.

**Properties**

| Name         | Type   | Required | Description                                                                      |
| :----------- | :----- | :------- | :------------------------------------------------------------------------------- |
| Host         | string | ✅       | The New Relic endpoint host for log ingestion (e.g., log-api.newrelic.com).      |
| IngestionKey | string | ✅       | The New Relic license or ingestion key used for authentication and data routing. |
