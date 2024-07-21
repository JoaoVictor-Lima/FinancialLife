## Select
This component has with function show various options in a list for the user select one.  

### Props 
- **ClassName** > Styling class.  
- **URL** >  This propert storage the URL for request API.  
- **Options** > Responsible for storing the objects coming from the API or specified in the code.  
- **Value** > the value of object selected.  
- **Placeholder** > Temporary text show in the component.    
- **loadOnFocus** > When true, fire the request method when the component comes into focus.  

### Events
- **onChange** > Fire when the content in the select change.  
- **onFocus** > Fire when the component comes into focus.  

### Methods
- **useEffect** > Effect Method.  
- **getSelectOptions** > get data according to url or options informed.  
- **getOptions** > get options from API.  
- **isEnum** > Verify if url is enum.  
- **handleFocus** > Fire when the component comes into focus.  
- **handleSelectChange** > Fire when the content in the select change.  