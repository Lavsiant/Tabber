import React from 'react';
import { Link } from 'react-router-dom';
import { connect } from 'react-redux';

import Input from '@material-ui/core/Input';
import { userActions } from './userActions.jsx';
import Paper from '@material-ui/core/Paper';
import Button from '@material-ui/core/Button';

class LoginPage extends React.Component {
    constructor(props) {
        super(props);

        // reset login status
        this.props.dispatch(userActions.logout());

        this.state = {
            username: '',
            password: '',
            submitted: false
        };

        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
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

    render() {
        const { username, password, submitted } = this.state;
        return (
            <Paper className='login'>
                <div className="col-md-6 col-md-offset-3">
                    <h2>Login</h2>
                    <form name="form" onSubmit={this.handleSubmit}>
                        <div className='login-field'>
                            <Input type="text" placeholder="Login" className="form-control" name="username" value={username} onChange={this.handleChange} />
                        </div>
                        <div className='login-field'>
                            <Input type="password" placeholder="Password" className="form-control" name="password" value={password} onChange={this.handleChange} />
                        </div>
                        <div className="form-group">
                            <Button size='large' type='submit' className="form-group">Login</Button>
                          
                        </div>
                    </form>
                </div>
            </Paper>
        );
    }
}

function mapStateToProps(state) {
    const { loggingIn } = state.authentication;
    return {
        loggingIn
    };
}

export default connect(mapStateToProps)(LoginPage);
