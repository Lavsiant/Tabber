import React from 'react';
import { Link } from 'react-router-dom';
import { connect } from 'react-redux';
import Input from '@material-ui/core/Input';
import { userActions } from './userActions.jsx';
import Paper from '@material-ui/core/Paper';
import Button from '@material-ui/core/Button';

class RegisterPage extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            user: {
                firstName: '',
                lastName: '',
                username: '',
                password: '',
                email: '',
            },
            open: false,
            submitted: false
        };
    }

    handleClickOpen = () => {
        this.setState({ open: true });
    };

    handleClose = () => {
        this.setState({ open: false });
    };

    handleChange = (event) => {
        const { name, value } = event.target;
        const { user } = this.state;
        this.setState({
            user: {
                ...user,
                [name]: value
            }
        });
    }

    handleSubmit = (event) => {
        event.preventDefault();

        this.setState({ submitted: true });
        const { user } = this.state;
        const { dispatch } = this.props;
        if (user.firstName && user.lastName && user.username && user.password) {
            dispatch(userActions.register(user));
        }
    }


    render() {
        const { registering } = this.props;
        const { user, submitted } = this.state;
        return (
            <Paper className='login' centered>
                <div className="col-md-6 col-md-offset-3">
                    <h2>Register</h2>
                    <form name="form" onSubmit={this.handleSubmit}>
                        <div >
                            <Input type="text" placeholder='First name' className="form-control" name="firstName" value={user.firstName} onChange={this.handleChange} required/>
                        </div>
                        <div className='login-field'>
                            <Input type="text" placeholder="Last name" className="form-control" name="lastName" value={user.lastName} onChange={this.handleChange} required/>
                        </div>
                        <div className='login-field' >
                            <Input type="text" placeholder='Username' className="form-control" name="username" value={user.username} onChange={this.handleChange}  required/>
                        </div>
                        <div className='login-field'>
                            <Input type="password" placeholder='Wassword' className="form-control" name="password" value={user.password} onChange={this.handleChange} required />
                        </div>
                        <div className='login-field'>
                            <Input type="email" name="email" placeholder = 'Email' value={user.email} onChange={this.handleChange}  required/>
                        </div>
                        <div className="form-group">
                            <Button type="submit" className="btn btn-primary" flat>Register</Button>
                         
                        </div>
                    </form>
                </div>
            </Paper>
        );
    }
}

function mapStateToProps(state) {
    const { registering } = state.registration;
    return {
        registering
    };
}

export default connect(mapStateToProps)(RegisterPage);

