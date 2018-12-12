import React from 'react';
import ReactDOM from 'react-dom';

export default class RequestTest extends React.Component{
    constructor() {
        super();
        this.state = {
            request: '',          
        };
    }

    onChange = (e) => {
        this.setState({request: e.target.value});
    }

    sendRequest = () => {
        fetch('https://localhost:44386/' + this.state.request)
            .then((response) => {
                return response.json()
            }).then((data) => {
                alert(data)
            }).catch((ex) => {
                alert(ex)
            });
    }

    render() {
        return(
            <div>
                <input type="text" onChange={this.onChange}></input>
                <button onClick={this.sendRequest}> Go </button>
            </div>
        )
    }
}