
import React from 'react';
import './App.css';

export default class App extends React.Component {

  constructor() {
    super();
    this.state={
      
      id:"",
      name:""
    }
  }

submit()
{
  
  console.log(this.state)
  let url ="https://localhost:44347/student/create";
 let  data=this.state;
 fetch (url,{
  method:'POST',
  headers: {
    "Content-Type":"application/json",
    "Accept" : "application.json"

  },
  body:JSON.stringify(data)
}).then((result)=> {
  result.json() .then((resp)=> {
    console.warn("resp",resp)
  })
})
}
 
  
  

render() {
  return (
    <div className="App">
    <h1>from</h1>
    <input type="text" value={this.state.name} name="name" 
    onChange={(data)=>{this.setState({name:data.target.value})}} /> <br /> <br />

    <input type="text" value={this.state.salary} name="id" 
    onChange={(data)=>{this.setState({id:data.target.value})}} /> <br /> <br />


    
    <button onClick={() => {this.submit()}} > submit data </button>
    </div>
  );
}
}



