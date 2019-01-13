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
import Button from '@material-ui/core/Button';
import { config } from '../../helpers/config.jsx';
import { withStyles } from '@material-ui/core/styles';
import ExpansionPanel from '@material-ui/core/ExpansionPanel';
import ExpansionPanelSummary from '@material-ui/core/ExpansionPanelSummary';
import ExpansionPanelDetails from '@material-ui/core/ExpansionPanelDetails';
import Typography from '@material-ui/core/Typography';
import NoSsr from '@material-ui/core/NoSsr';
import ExpandMoreIcon from '@material-ui/icons/ExpandMore';

export default class CreateCourse extends React.Component {
    constructor() {
        super();
        this.state = {
            name: '',
            description: '',
            creator: '',
            type: 0,
            lesson: {
                name: '',
                repeat: 1,
                startBpm: 60,
                stepBpm: 5,
                tab: -1

            },
            lessons: [],
            tabs: []
        };

        if (localStorage.getItem('user')) {
            this.state.creator = JSON.parse(localStorage.getItem('user')).username;
        }
        else {
            window.location = config.apiUrl + "/login";
        }

    }

    componentWillMount() {
        this.getTabs().then((data) => {
            this.setState({ tabs: data });

        });


    }

    getTabs = () => {
        return fetch('api/Tab/tabs')
            .then((response) => response.json());

    }

    handleChange = (e) => {
        const { name, value } = e.target;
        this.setState({ [name]: value });
    }

    handleLessonChange = (e) => {
        const { name, value } = e.target;
        const { lesson } = this.state;
        lesson[name] = value;
        console.log(value);
        this.setState({ lesson: lesson })
    }

    handleAddLessonClickButton = () => {
        const { lesson, lessons } = this.state;
        if (lesson.name !== '' &&
            lesson.tab !== -1) {
            lessons.push(lesson);

        }
        this.setState({ lessons: lessons });
    }

    handleSubmit = () => {
        this.createTab(this.state);
    }

    createTab = (course) => {
        const name = JSON.parse(localStorage.getItem('user')).username;
        const url = 'api/Course/course-create?name=' + name;
        const request = {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(course)
        };
        fetch(url, request)
            .then((response) => {
                return response.json()
            }).then((data) => {
                window.location = config.apiUrl + "/courses";
                // window.location = config.apiUrl + "/tabs";
            }).catch((ex) => {

            });

    }

    render() {
        const { tabs } = this.state.tabs;
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
                            <TextField
                                style={{ width: '90%' }}
                                label="Course name"
                                className={styles.textField}
                                type="text"
                                name="name"
                                autoComplete="Username"
                                margin="normal"
                                variant="outlined"
                                value={this.state.name}
                                onChange={this.handleChange}
                                required
                            />

                        </div>
                        <div className='field'>
                            <TextField
                                style={{ width: '90%' }}
                                label="Description"
                                className={styles.textField}
                                type="text"
                                name="description"
                                autoComplete="Username"
                                margin="normal"
                                variant="outlined"
                                value={this.state.description}
                                onChange={this.handleChange}
                                required
                            />
                        </div>
                        <div className='field'>

                            <TextField
                                select
                                label="Select type"
                                className={styles.textField}
                                style={{ width: '90%' }}
                                value={this.state.type}
                                name='type'
                                SelectProps={{
                                    MenuProps: {
                                        className: styles.menu,
                                    },
                                }}
                                helperText="Please select type"
                                margin="normal"
                                variant="outlined"
                                onChange={this.handleChange}
                            >
                                <MenuItem value={1}>Acoustic Guitar</MenuItem>
                                <MenuItem value={2}>Electric Guitar</MenuItem>
                                <MenuItem value={3}>Classical Guitar</MenuItem>
                            </TextField>
                        </div>
                        <div style={{marginBot: 40}}>
                        {this.state.lessons.map(lesson => {
                            return (
                                <ExpansionPanel style={{ width: '82%', margin: 'auto', marginBop: '15' }}>
                                    <ExpansionPanelSummary expandIcon={<ExpandMoreIcon />}>
                                        <Typography >{lesson.name}</Typography>
                                    </ExpansionPanelSummary>
                                    <ExpansionPanelDetails>
                                        <Typography style={{ fontSize: 15 }}>
                                            Lesson name: {lesson.name}   Repeat times: {lesson.repeat}   Start bpm: {lesson.startBpm}  Default step: {lesson.stepBpm}
                                        </Typography>
                                    </ExpansionPanelDetails>
                                </ExpansionPanel>
                                // <Paper className='root' style={{textAlign:'left', width:'max-content', margin:'auto' ,marginBottom:20}}>
                                //     <label>Lesson name: {lesson.name} </label>
                                //     <label>Repeat: {lesson.name} </label>
                                //     <label>Start Bpm: {lesson.startBpm} </label>
                                //     <label>Step Bpm: {lesson.stepBpm} </label>

                                //     <Button type='button' onClick={() => this.handleRemoveIterationClickButton(counter)} style={{ marginLeft: 5 }}>Remove</Button>
                                // </Paper>
                            );
                        })}
                        </div>
                        <div style={{marginTop: 40}}>
                        <Paper className='root' style={{ width: '70%', margin: 'auto' }}>
                            <TextField
                                style={{ width: '90%' }}
                                label="Lesson name"
                                className={styles.textField}
                                type="text"
                                name="name"
                                autoComplete="Username"
                                margin="normal"
                                variant="outlined"
                                value={this.state.lesson.name}
                                onChange={this.handleLessonChange}
                                required
                            />

                            <div className='form-control'>
                                <TextField
                                    select
                                    label="Select tab"
                                    className={styles.textField}
                                    style={{ width: '90%' }}
                                    value={this.state.lesson.tab}
                                    name='tab'
                                    SelectProps={{
                                        MenuProps: {
                                            className: styles.menu,
                                        },
                                    }}
                                    margin="normal"
                                    variant="outlined"
                                    onChange={this.handleLessonChange}
                                >
                                    {this.state.tabs.map(tab => {
                                        return (
                                            <MenuItem value={tab.id}>{tab.name}</MenuItem>);
                                    })}

                                </TextField>
                              
                            </div>
                            <TextField
                                style={{ width: '90%' }}
                                label="Number to repeat"
                                className={styles.textField}
                                type="text"
                                name="repeat"
                                autoComplete="Username"
                                margin="normal"
                                variant="outlined"
                                value={this.state.lesson.repeat}
                                onChange={this.handleLessonChange}
                                required
                            />
                            <br />
                            <TextField
                                style={{ width: '90%' }}
                                label="Start bpm for learning"
                                className={styles.textField}
                                type="text"
                                name="startBpm"
                                autoComplete="Username"
                                margin="normal"
                                variant="outlined"
                                value={this.state.lesson.startBpm}
                                onChange={this.handleLessonChange}
                                required
                            />
                            <br />
                            <TextField
                                style={{ width: '90%' }}
                                label="Step bpm"
                                className={styles.textField}
                                type="text"
                                name="stepBpm"
                                autoComplete="Username"
                                margin="normal"
                                variant="outlined"
                                value={this.state.lesson.stepBpm}
                                onChange={this.handleLessonChange}
                                required
                            />

                            <br />
                            <Button variant="contained" color="primary" type='button' onClick={this.handleAddLessonClickButton} style={{ marginLeft: 5 }}>Add</Button>

                        </Paper>
                        </div>


                        <div className="form-group">
                            <Button variant="contained" color="primary" size='large' type='submit' className="form-group" style={{ margin: 'auto' }}>Create</Button>
                        </div>
                    </form>
                </div>
            </Paper>
        );
    }
}

