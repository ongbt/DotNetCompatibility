|-|-|-|-|-|-|-|
|Library|netstandard20|netstandard21|netcoreapp31|net5|
|App|-|-|-|-|-|-|
|netstandard20|-|-|-|-|-|-|
|netstandard21|O|O|X|X|-|-| - CS1705 Assembly 'netcoreapp31' with identity 'netcoreapp31, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null' uses 'System.Runtime, Version=4.2.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' which has a higher version than referenced assembly 'System.Runtime' with identity 'System.Runtime, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
							- CS1705 Assembly 'net5' with identity 'net5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null' uses 'System.Runtime, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' which has a higher version than referenced assembly 'System.Runtime' with identity 'System.Runtime, Version=4.2.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'|
|netcoreapp31|O|O|O|X|CS1705 Assembly 'net5' with identity 'net5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null' uses 'System.Runtime, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' which has a higher version than referenced assembly 'System.Runtime' with identity 'System.Runtime, Version=4.2.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'|
|net5|O|O|O|O|-|





-------
netcoreapp31
cannot reference net5 library
App: AppNetCore31, calling: netcoreapp31
netstandard21
App: AppNetCore31, calling: netstandard21
netstandard20
App: AppNetCore31, calling: netstandard20
-------