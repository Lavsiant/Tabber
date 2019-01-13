import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom';
import Header from './header/header.jsx';
import Routing from '../routes/route.jsx';
import About from './about/about.jsx';
import AppBar from '@material-ui/core/AppBar';


export default class App extends React.Component {
    render() {
        return (
            <Router>
                <div style={{fontSize: 20, fontFamily: 'Roboto'}}>
                    <Header />
                    <Routing />                  
                </div>
            </Router>
        );
    }
};