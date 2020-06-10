## FileConvertor Notes

I was briefed to spend two hours on this.

I have concentrated on demonstrating OOP principles. I have applied several aspects of SOLID to the solution.

This can be seen as a proof of concept and not production ready. 
+ I have not created any tests. For an example of unit tests see https://github.com/earthinferno/StreetLighting/tree/master/StreetLightingXUnitTests
+ The implementation of IDataImporter is not of high quality.
+ I would not structure an application like this. For example I have made an abstraction of DataConvertor so I'd 
  probably put it and it's intefaces into a seperate container (e.g. package). 