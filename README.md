# 00-dotnet-tutorial
.NET tutorial
Goal
The Strategy pattern’s goal is to extract an algorithm (strategy) from the host class needing it (the
context). That allows the consumer to decide on the strategy (algorithm) to use at runtime.
For example, we could design a system that fetches data from two different types of databases. Then
we could apply the same logic over that data and use the same user interface to display it. To achieve
this, using the Strategy pattern, we could create two strategies, one named FetchDataFromSql and
the other FetchDataFromCosmosDb. Then we could plug the strategy that we need at runtime in the
context class. That way, when the consumer calls the context, the context does not need to know
where the data comes from, how it is fetched, or what strategy is in use; it only gets what it needs to
work, delegating the fetching responsibility to an abstracted strategy.

![alt text](https://github.com/9health/00-dotnet-tutorial/blob/DP-Strategy/DP-Strategy.jpg?raw=true)
