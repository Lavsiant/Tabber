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
        let language = '';
        if(localStorage.getItem('lang')){
            language = localStorage.getItem('lang');
        }
        else{
            language = 'en';
            localStorage.setItem('lang', 'en');
        }
        
        if (localStorage.getItem('user')) {
            authControl =  
                <Tabs   indicatorColor="primary" textColor="primary" value={this.state.value}  onChange={this.handleChange} centered>
                <Tab label={language == 'en' ? "Tabs" : 'Табулатури'} component={Link} to="/tabs" />
                <Tab label={language == 'en' ? "Courses" : 'Курси'} component={Link} to="/courses" /> 
                {/* <Tab label="Test tab" component={Link} to="/test" />                        */}
                <Tab label={language == 'en' ? "Logout" : 'Вихід'} onClick={this.handleLogOut} component={Link} to="/login" />     
                <Tab style={{float: 'right'}} label={language == 'en' ? "Profile" : 'Профіль'} component={Link} to="/profile" />           
        </Tabs>     
        } else {
            authControl =   
                <Tabs indicatorColor="primary" textColor="primary" value={this.state.value}  onChange={this.handleChange} centered>
                <Tab label={language == 'en' ? "Tabs" : 'Табулатури'} component={Link} to="/tabs" />
                <Tab label={language == 'en' ? "Courses" : 'Курси'} component={Link} to="/courses" /> 
                {/* <Tab label={language == 'en' ? "Test tab" : ''} component={Link} to="/test" />          */}
                <Tab label={language == 'en' ? "Register" : 'Реєстрація'} component={Link} to="/register" />     
                <Tab label={language == 'en' ? "Login" : 'Вхід'} component={Link} to="/login" />;         
        </Tabs>     
        }

        return (
            <AppBar color="default">{authControl}</AppBar>        
        );
    }
};
