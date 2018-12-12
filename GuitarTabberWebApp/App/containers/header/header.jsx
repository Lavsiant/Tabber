import React from 'react';
import { Link } from 'react-router-dom';

import Tab from "@material-ui/core/Tab";
import Tabs from "@material-ui/core/Tabs";
import Paper from '@material-ui/core/Paper';

export default class Header extends React.Component {
    state = {
        value: 0     
    };
    
    handleChange = (event, value) => {
        this.setState({ value });
    };

    render() {
        return (
            <Paper>
                <Tabs value={this.state.value}  onChange={this.handleChange} centered>
                    <Tab label="Tabs" component={Link} to="/tabs" />
                    <Tab label="About" component={Link} to="/about" /> 
                    <Tab label="Test tab" component={Link} to="/test" />         
                    <Tab label="Register" component={Link} to="/register" />         
                </Tabs>                   
            </Paper>   
        );
    }
};
