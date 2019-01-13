import React from 'react';
import { Link } from 'react-router-dom';
import { connect } from 'react-redux';
import Input from '@material-ui/core/Input';
import { userActions } from './userActions.jsx';
import Paper from '@material-ui/core/Paper';
import TextField from '@material-ui/core/TextField';
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
        const styles = theme => ({
            container: {
                display: 'flex',
                flexWrap: 'wrap',
            },
            textField: {
                marginLeft: theme.spacing.unit,
                marginRight: theme.spacing.unit,
            },
            dense: {
                marginTop: 16,
            },
            menu: {
                width: 200,
            },
        });
        return (
            <Paper className='login' centered style={{marginTop:200}}>
                <div className="col-md-6 col-md-offset-3">
                    <h2>Register</h2>
                    <form name="form" onSubmit={this.handleSubmit}>
                        <div >
                            <TextField
                                style={{ width: '90%' }}
                                label="First name"
                                className={styles.textField}
                                type="text"
                                name="firstName"
                                autoComplete="Username"
                                margin="normal"
                                variant="outlined"
                                value={user.firstName}
                                onChange={this.handleChange}
                                required
                            />               
                         
                        </div>
                        <div className='login-field'>
                        <TextField
                                style={{ width: '90%' }}
                                label="Last name"
                                className={styles.textField}
                                type="text"
                                name="lastName"
                                autoComplete="Lastname"
                                margin="normal"
                                variant="outlined"
                                value={user.lastName}
                                onChange={this.handleChange}
                                required
                            />    
                           
                        </div>
                        <div className='login-field' >
                        <TextField
                                style={{ width: '90%' }}
                                label="Username"
                                className={styles.textField}
                                type="text"
                                name="username"
                                autoComplete="Username"
                                margin="normal"
                                variant="outlined"
                                value={user.username}
                                onChange={this.handleChange}
                                required
                            />    
                           
                        </div>
                        <div className='login-field'>
                        <TextField
                                style={{ width: '90%' }}
                                label="Passwprd"
                                className={styles.textField}
                                type="password"
                                name="password"
                                autoComplete="Username"
                                margin="normal"
                                variant="outlined"
                                value={user.password}
                                onChange={this.handleChange}
                                required
                            />    
                          
                        </div>
                        <div className='login-field'>
                        <TextField
                                style={{ width: '90%' }}
                                label="Email"
                                className={styles.textField}
                                type="email"
                                name="email"
                                autoComplete="Username"
                                margin="normal"
                                variant="outlined"
                                value={user.email}
                                onChange={this.handleChange}
                                required
                            />    
                           
                        </div>
                        <div className="form-group" style={{paddingBottom: 20}}>
                            <Button size="large" variant="contained" type='submit' style={{ marginBot:20}}  color="primary">
                                Register
                            </Button>
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

