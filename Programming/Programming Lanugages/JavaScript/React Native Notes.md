# React Native Notes

## React Native CLI

Useful commands:
- `npx react-native init <project-name>`
- `npx react-native run-android`
- `npx react-native run-ios`
- `npx react-native start`
- `npx react-native start --reset-cache`
- `sudo npm install -g react-devtools`

## React Native Components

### Text Component

**Text Component** - Fundamental React Native component similar to `<p>` in web development used to display text

```jsx
import { Text } from 'react-native';

<Text>Hello, world!</Text>
```

### View Component

**View Component** - Fundamental React Native component similar to `<div>` in web development used to create a container for other components

```jsx
import { View } from 'react-native';

<View style={{ flex: 1, justifyContent: 'center', alignItems: 'center' }}>
  <Text>Hello, world!</Text>
</View>
```

### Image Component

**Image Component** - React Native component used to display images

```jsx
import { Image } from 'react-native';

<Image
  source={{
	uri: 'https://reactnative.dev/img/tiny_logo.png',
  }}
  style={{ width: 50, height: 50 }}
/>
```

### Button Component

**Button Component** - React Native component used to create a button

```jsx
import { Button } from 'react-native';

<Button
  title="Press me"
  onPress={() => alert('Button pressed!')}
/>
```

### TextInput Component

**TextInput Component** - React Native component used to create an input field

```jsx
import { TextInput } from 'react-native';

<TextInput
  placeholder="Enter your name"
  onChangeText={(text) => console.log(text)}
/>
```

### ScrollView Component

**ScrollView Component** - React Native component used to create a scrollable container

```jsx
import { ScrollView } from 'react-native';

<ScrollView>
  <Text>Line 1</Text>
  <Text>Line 2</Text>
  <Text>Line 3</Text>
  <Text>Line 4</Text>
  <Text>Line 5</Text>
</ScrollView>
```

### FlatList Component

**FlatList Component** - React Native component used to render a list of items

```jsx
import { FlatList } from 'react-native';

const data = [
  { key: '1', name: 'Alice' },
  { key: '2', name: 'Bob' },
  { key: '3', name: 'Charlie' },
];

<FlatList
  data={data}
  renderItem={({ item }) => <Text>{item.name}</Text>}
/>
```

### SectionList Component

**SectionList Component** - React Native component used to render a list of items with sections

```jsx
import { SectionList } from 'react-native';

const data = [
  {
	title: 'Group 1',
	data: [
	  { key: '1', name: 'Alice' },
	  { key: '2', name: 'Bob' },
	],
  },
  {
	title: 'Group 2',
	data: [
	  { key: '3', name: 'Charlie' },
	  { key: '4', name: 'David' },
	],
  },
];

<SectionList
  sections={data}
  renderItem={({ item }) => <Text>{item.name}</Text>}
  renderSectionHeader={({ section }) => <Text>{section.title}</Text>}
/>
```

### Touchable Components

**Touchable Components** - React Native components used to create touchable elements

```jsx
import { TouchableOpacity, TouchableHighlight, TouchableWithoutFeedback } from 'react-native';

<TouchableOpacity onPress={() => alert('TouchableOpacity pressed!')}>
  <Text>Press me</Text>
</TouchableOpacity>

<TouchableHighlight onPress={() => alert('TouchableHighlight pressed!')}>
  <Text>Press me</Text>
</TouchableHighlight>

<TouchableWithoutFeedback onPress={() => alert('TouchableWithoutFeedback pressed!')}>
  <Text>Press me</Text>
</TouchableWithoutFeedback>
```

## React Native Navigation

### Stack Navigation

```jsx
import { createStackNavigator } from '@react-navigation/stack';

const Stack = createStackNavigator();

function App() {
  return (
	<NavigationContainer>
	  <Stack.Navigator>
		<Stack.Screen name="Home" component={HomeScreen} />
		<Stack.Screen name="Details" component={DetailsScreen} />
	  </Stack.Navigator>
	</NavigationContainer>
  );
}
```

### Tab Navigation

```jsx
import { createBottomTabNavigator } from '@react-navigation/bottom-tabs';

const Tab = createBottomTabNavigator();

function App() {
  return (
	<NavigationContainer>
	  <Tab.Navigator>
		<Tab.Screen name="Home" component={HomeScreen} />
		<Tab.Screen name="Settings" component={SettingsScreen} />
	  </Tab.Navigator>
	</NavigationContainer>
  );
}
```

