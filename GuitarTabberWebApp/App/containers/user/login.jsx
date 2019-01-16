import React from 'react';
import { Link } from 'react-router-dom';
import { connect } from 'react-redux';

import Input from '@material-ui/core/Input';
import { userActions } from './userActions.jsx';
import Paper from '@material-ui/core/Paper';
import Button from '@material-ui/core/Button';
import TextField from '@material-ui/core/TextField';


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
        let language = '';
        if (localStorage.getItem('lang')) {
            language = localStorage.getItem('lang');
        }
        else {
            language = 'en';
            localStorage.setItem('lang', 'en');
        }

        return (
            <Paper className='login' style={{ marginTop: 300 }}>

                <h2 style={{ color: '#666' }}>{language == 'en' ? 'Login' : 'Вхід'}</h2>
                <form name="form" onSubmit={this.handleSubmit}>
                    <div className='login-field'>
                        <TextField
                            style={{ width: '90%' }}
                            label={language == 'en' ? 'Login' : 'Логін'}
                            className={styles.textField}
                            type="text"
                            name="username"
                            autoComplete="Username"
                            margin="normal"
                            variant="outlined"
                            value={username}
                            onChange={this.handleChange}
                        />
                    </div>
                    <div className='login-field'>
                        <TextField
                            style={{ width: '90%' }}
                            label={language == 'en' ? "Password" : 'Пароль'}
                            className={styles.textField}
                            type="password"
                            name="password"
                            autoComplete="Username"
                            margin="normal"
                            variant="outlined"
                            value={password}
                            onChange={this.handleChange}
                        />
                    </div>
                    <div className="form-group" style={{ justifyContent: 'space-between', display: 'flex', paddingBottom: 20 }}>
                        <Button variant="contained" type='submit' style={{ float: 'left', marginBot: 20 }} color="primary">
                            {language == 'en' ? 'Sign in' : 'Реэстрація'}
                        </Button>
                        <Button variant="contained" type='submit' style={{ float: 'right', marginBot: 20 }} color="primary">
                            {language == 'en' ? 'Login' : 'Вхід'}
                        </Button>


                    </div>
                </form>

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
