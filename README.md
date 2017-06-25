# Example of how to have objects observe one another for state change in Unity

A quick and simple example of two approached

## Constantly poll in the update loop 
Down side here is any object using this pattern has to be a MonoBehavior and has to exist in the game scene because it depends on the update loop. Additionally you have deal with handling the event only once and then stopping.

## Use Delegates
In this case I use an Action (built in C# class for creating simple delegates). You can define your own custom delegates in C# if you need them.

THis approach has the upside of not needing to be a MonoBehavior and does not have to exist in the game scene. Additionally this approach means you only deal with the state change when the even you care about actually occurs. It offers other benifits as well.

For further reading you can look up the "Observer Pattern" OOP design pattern. This pattern is what MVC (model-view-controller) is built upon.