# React Notes

## Context API

Context API - A way in React to pass data through the component tree without having to pass props down manually at every level

```javascript
import React, { createContext, useContext } from 'react';

const MyContext = createContext();

const MyProvider = ({ children }) => {
  const value = 'Hello, World!';
  return <MyContext.Provider value={value}>{children}</MyContext.Provider>;
};

const MyComponent = () => {
  const value = useContext(MyContext);
  return <p>{value}</p>;
};

const App = () => {
  return (
	<MyProvider>
	  <MyComponent />
	</MyProvider>
  );
};

export default App;
```

## Use Effect Hook

useEffect() - A built-in React hook that allows you to perform side effects in function components
- The first argument is a function that contains the side effect code
- The second argument is an array of dependencies that determines when the side effect should run
- If the second argument is an empty array, the side effect will only run once when the component mounts
- If the second argument is not provided, the side effect will run every time the component renders

```javascript
import React, { useState, useEffect } from 'react';

const MyComponent = () => {
  const [count, setCount] = useState(0);

  useEffect(() => {
	document.title = `You clicked ${count} times`;
  }, [count]);

  return (
	<div>
	  <p>You clicked {count} times</p>
	  <button onClick={() => setCount(count + 1)}>Click me</button>
	</div>
  );
};

export default MyComponent;
```

## Use State Hook

useState() - A built-in React hook that allows you to add state to function components
- The useState() function returns an array with two elements: the current state value and a function to update the state
- The first element of the array is the current state value, and the second element is a function that updates the state

```javascript
import React, { useState } from 'react';

const MyComponent = () => {
  const [count, setCount] = useState(0);

  return (
	<div>
	  <p>You clicked {count} times</p>
	  <button onClick={() => setCount(count + 1)}>Click me</button>
	</div>
  );
};

export default MyComponent;
```

## Refs

Refs - A way to access DOM nodes or React elements created in the render method

```javascript
import React, { useRef } from 'react';

const MyComponent = () => {
  const inputRef = useRef();

  const handleClick = () => {
	inputRef.current.focus();
  };

  return (
	<div>
	  <input ref={inputRef} type="text" />
	  <button onClick={handleClick}>Focus Input</button>
	</div>
  );
};

export default MyComponent;
```

