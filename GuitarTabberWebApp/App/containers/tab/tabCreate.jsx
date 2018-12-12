import React from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import Paper from '@material-ui/core/Paper';
import TextField from '@material-ui/core/TextField';
import FormControl from '@material-ui/core/FormControl';
import Select from '@material-ui/core/Select';
import InputLabel from '@material-ui/core/InputLabel';
import MenuItem from '@material-ui/core/MenuItem';
import Input from '@material-ui/core/Input';

class CreateTab extends React.Component {
    constructor() {
        super();
        this.state = {
            name = '',
            tempo = 0
        };
    }

    handleChange(e) {
        const { name, value } = e.target;
        this.setState({ [name]: value });
    }

    handleSubmit(e) {
        e.preventDefault();

        this.setState({ submitted: true });
        const { username, password } = this.state;
        const { dispatch } = this.props;
        if (username && password) {
            dispatch(userActions.login(username, password));
        }
    }


    render(){
        return(
            <Paper className='root'>
                 <div className="col-md-6 col-md-offset-3">
                    <h2>Login</h2>
                    <form name="form" onSubmit={this.handleSubmit}>
                        <div className='login-field'>
                            <Input type="text" placeholder="Tab name" className="form-control" name="name" value={username} onChange={this.handleChange} />
                        </div>
                        <div className='login-field'>
                            <Input type="number" placeholder="Tempo" className="form-control" name="password" value={password} onChange={this.handleChange} />
                        </div>
                        <FormControl className={classes.formControl}>
                            <InputLabel htmlFor="age-simple">Type</InputLabel>
                            <Select
                                value={this.state.age}
                                onChange={this.handleChange}
                                inputProps={{
                                name: 'age',
                                id: 'age-simple',
                                }}
                            >
                                <MenuItem value="">
                                <em>None</em>
                                </MenuItem>
                                <MenuItem value={1}>Guitar</MenuItem>
                                <MenuItem value={2}>Drums</MenuItem>
                                <MenuItem value={3}>Piano</MenuItem>
                            </Select>
                        </FormControl>
                        <div className="form-group">
                            <Button size='large' type='submit' className="form-group">Create</Button>
                          
                        </div>
                    </form>
                </div>
            </Paper>
        )
    }
}

let mapProps = (state) => {
    return {
        tab: state.tabReducer.tab,
        error: state.tabReducer.error
    }
}

let mapDispatch = (dispatch) => {
    return {
        createTab: bindActionCreators(createTab, dispatch),
    }
}

export default connect(mapProps, mapDispatch)(TabDetails) 