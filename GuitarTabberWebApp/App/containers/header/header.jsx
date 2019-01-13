import React from 'react';
import { Link } from 'react-router-dom';

import Tab from "@material-ui/core/Tab";
import Tabs from "@material-ui/core/Tabs";
import Paper from '@material-ui/core/Paper';
import { AppBar } from '@material-ui/core';

export default class Header extends React.Component {
    state = {
        value: 0 ,
        isLoggedIn: false    
    };
    
    handleChange = (event, value) => {
        this.setState({ value });
    };

    handleLoginClick = () => {
        this.setState({isLoggedIn: true});
      }
    
      handleLogoutClick = () => {
        this.setState({isLoggedIn: false});
      }

      handleLogOut = () => {
        localStorage.removeItem('user');
      }

    render() {
        const isLoggedIn = this.state.isLoggedIn;
        let authControl;
        
        if (localStorage.getItem('user')) {
            authControl =  
                <Tabs   indicatorColor="primary" textColor="primary" value={this.state.value}  onChange={this.handleChange} centered>
                <Tab label="Tabs" component={Link} to="/tabs" />
                <Tab label="Courses" component={Link} to="/courses" /> 
                <Tab label="Test tab" component={Link} to="/test" />                       
                <Tab label="Logout" onClick={this.handleLogOut} component={Link} to="/login" />             
        </Tabs>     
        } else {
            authControl =   
                <Tabs indicatorColor="primary" textColor="primary" value={this.state.value}  onChange={this.handleChange} centered>
                <Tab label="Tabs" component={Link} to="/tabs" />
                <Tab label="Courses" component={Link} to="/courses" /> 
                <Tab label="Test tab" component={Link} to="/test" />         
                <Tab label="Register" component={Link} to="/register" />     
                <Tab label="Login" component={Link} to="/login" />;         
        </Tabs>     
        }

        return (
            <AppBar color="default">{authControl}</AppBar>        
        );
    }
};
