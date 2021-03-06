import React from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import { getUser } from './userActions.jsx'
import Paper from '@material-ui/core/Paper';
import { userActions } from './userActions.jsx';
import { config } from '../../helpers/config.jsx';
import TextField from '@material-ui/core/TextField';
import { FormLabel } from '@material-ui/core';
import MenuItem from '@material-ui/core/MenuItem';

import Button from '@material-ui/core/Button';

import "isomorphic-fetch";


export default class UserDetails extends React.Component {
    constructor() {
        super();
        this.state = {
            user: {},
            language: ''
        };
        
        if(localStorage.getItem('lang')){
            this.state.language = localStorage.getItem('lang');
        }
        else{
            this.state.language = 'en';
        }

        if (localStorage.getItem('user')) {
            this.state.user = JSON.parse(localStorage.getItem('user')).username;
        }
        else {
            window.location = config.apiUrl + "/login";
        }
    }

    componentDidMount() {
        //this.props.getUser(this.props.id);
        this.getUser().then((data) => {
            this.setState({ user: data });
        });
        //  this.state.selectedTab =  this.props.tabs ? this.props.tabs[0] : null
    }

    getUser = () => {
        const name = JSON.parse(localStorage.getItem('user')).username;
        const url = config.apiUrl + '/api/Identity/user-full?userName=' + name;
        return fetch(url)
            .then((response) => response.json());
    }

    handleChange = (e) => {
        const { name, value } = e.target;
        let { user } = this.state;
        user[name] = value;
        this.setState({ user: user });
    }

    handleLangChange = (e) => {
        const {value} = e.target;
        this.setState({ language: value });
        localStorage.setItem('lang', value);

    }

    handleSubmit = () => {
        const url = 'api/Identity/user-update';
        const request = {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(this.state.user)
        };
        fetch(url, request)
            .then((response) => {
                return response.json()
            }).then((data) => {
                window.location = config.apiUrl + "/tabs";
                // window.location = config.apiUrl + "/tabs";
            }).catch((ex) => {

            });
    }

    render() {
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
            <Paper className='tab-create' style={{ fontSize: 20, marginTop: 100 }} >
                <div style={{ textAlign: 'center' }}>

                    <form name="form" className='tab-create-form' onSubmit={this.handleSubmit} style={{ textAlign: 'center' }}>
                        <div className='field'>
                            <FormLabel style={{ fontSize: 22 }}>{this.state.language=='en' ? 'Username' : 'Логін'} </FormLabel>
                            <br />
                            <TextField
                                style={{ width: '90%' }}
                                label=""
                                className={styles.textField}
                                type="text"
                                name="name"
                                autoComplete="Username"
                                margin="normal"
                                variant="outlined"
                                value={this.state.user.userName}
                                onChange={this.handleChange}
                                required
                            />

                        </div>
                        <div className='field'>
                            <FormLabel style={{ fontSize: 22 }}>{this.state.language=='en' ? 'New Password' : 'Новий пароль'} </FormLabel>
                            <br />
                            <TextField
                                style={{ width: '90%' }}
                                label=""
                                className={styles.textField}
                                type="password"
                                name="password"
                                autoComplete="Username"
                                margin="normal"
                                variant="outlined"
                                value={this.state.user.password}
                                onChange={this.handleChange}
                                required
                            />
                        </div>
                        <div className='field'>
                            <FormLabel style={{ fontSize: 22 }}> Email </FormLabel>
                            <br />
                            <TextField
                                style={{ width: '90%' }}
                                label=""
                                className={styles.textField}
                                type="email"
                                name="email"
                                autoComplete="Username"
                                margin="normal"
                                variant="outlined"
                                value={this.state.user.email}
                                onChange={this.handleChange}
                                required
                            />
                        </div>

                        <div className='field'>
                            <FormLabel style={{ fontSize: 22 }}>{this.state.language=='en' ? 'First name' : 'Ім`я'} </FormLabel>
                            <br />
                            <TextField
                                style={{ width: '90%' }}
                                label=""
                                className={styles.textField}
                                type="text"
                                name="firstname"
                                autoComplete="Username"
                                margin="normal"
                                variant="outlined"
                                value={this.state.user.firstName}
                                onChange={this.handleChange}
                                required
                            />
                        </div>

                        <div className='field'>
                            <FormLabel style={{ fontSize: 22 }}>{this.state.language=='en' ? 'Last name' : 'Прізвище'} </FormLabel>
                            <br />
                            <TextField
                                style={{ width: '90%' }}
                                label=""
                                className={styles.textField}
                                type="text"
                                name="lastName"
                                autoComplete=""
                                margin="normal"
                                variant="outlined"
                                value={this.state.user.lastName}
                                onChange={this.handleChange}
                                required
                            />
                        </div>
                        <div className='field'>
                            <FormLabel style={{ fontSize: 22 }}>{this.state.language=='en' ? 'Biography' : 'Біографія'} </FormLabel>
                            <br />
                            <TextField
                                style={{ width: '90%' }}
                                label=""
                                className={styles.textField}
                                type="text"
                                name="bio"
                                autoComplete=""
                                margin="normal"
                                variant="outlined"
                                value={this.state.user.bio}
                                onChange={this.handleChange}
                                required
                            />
                        </div>
                        <div className='field'>
                            <TextField
                                select
                                label={this.state.language=='en' ? 'Select language' : 'Оберіть мову сайту'}
                                className={styles.textField}
                                style={{ width: '90%' }}
                                value={this.state.language}
                                name='type'
                                SelectProps={{
                                    MenuProps: {
                                        className: styles.menu,
                                    },
                                }}
                                margin="normal"
                                variant="outlined"
                                onChange={this.handleLangChange}
                            >
                                <MenuItem value={"en"}>English</MenuItem>
                                <MenuItem value={'ua'}>Українська</MenuItem>
                           
                            </TextField>
                        </div>
                        <Button variant="contained" color="primary" size='large' type='submit' className="form-group" style={{ margin: 'auto' }}>{this.state.language=='en' ? 'Update' : 'Оновити'}</Button>

                    </form>
                </div>
            </Paper>)
    }
}

let mapProps = (state) => {
    return {
        user: state.userDetailsReducer.user,
        error: state.userDetailsReducer.error
    }
}

let mapDispatch = (dispatch) => {
    return {
        getUser: bindActionCreators(userActions.getUser, dispatch),
    }
}

connect(mapProps, mapDispatch)(UserDetails) 