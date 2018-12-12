import React from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import Paper from '@material-ui/core/Paper';
import TextField from '@material-ui/core/TextField';

class CreateTab extends React.Component {
    constructor() {
        super();
        this.state = {
            
        };
    }

    render(){
        return(
            <Paper className='root'>
                 <TextField
                    id="standard-name"
                    label="Name"
                    className={classes.textField}
                    value={this.state.name}
                    onChange={this.handleChange('name')}
                    margin="normal"
                 />
            </Paper>
        )
    }
}