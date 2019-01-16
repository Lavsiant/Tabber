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
        this.setState({ lessons: lessons, lesson: {
            name: '',
            repeat: 1,
            startBpm: 60,
            stepBpm: 5,
            tab: -1
        } });
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
        let language = '';
        if(localStorage.getItem('lang')){
            language = localStorage.getItem('lang');
        }
        else{
            language = 'en';
            localStorage.setItem('lang', 'en');
        }
        return (
            <Paper className='tab-create' style={{ fontSize: 20, marginTop: 100 }} >
                <div style={{ textAlign: 'center' }}>

                    <form name="form" className='tab-create-form' onSubmit={this.handleSubmit} style={{ textAlign: 'center' }}>
                        <div className='field'>
                            <TextField
                                style={{ width: '90%' }}
                                label={language == 'en' ? "Course name" : 'Назва курсу'}
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
                                label={language == 'en' ? "Description" : 'Опис'}
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
                                label={language == 'en' ? "Select type" : 'Тип'}
                                className={styles.textField}
                                style={{ width: '90%' }}
                                value={this.state.type}
                                name='type'
                                SelectProps={{
                                    MenuProps: {
                                        className: styles.menu,
                                    },
                                }}
                                helperText={language == 'en' ? "Please select type" : "Будь ласка оберіть тип"}
                                margin="normal"
                                variant="outlined"
                                onChange={this.handleChange}
                            >
                                <MenuItem value={1}>{language == 'en' ? 'Acoustic Guitar' : 'Акустична гітара'}</MenuItem>
                                <MenuItem value={2}>{language == 'en' ? 'Electric Guitar' : 'Електрогітара'}</MenuItem>
                                <MenuItem value={3}>{language == 'en' ? 'Classical Guitar' : 'Класична гітара'}</MenuItem>
                            </TextField>
                        </div>
                        <div style={{marginBot: 40}}>
                        {this.state.lessons.map(x => {
                            return (
                                <ExpansionPanel style={{ width: '82%', margin: 'auto', marginBop: '15' }}>
                                    <ExpansionPanelSummary expandIcon={<ExpandMoreIcon />}>
                                        <Typography >{x.name}</Typography>
                                    </ExpansionPanelSummary>
                                    <ExpansionPanelDetails>
                                        <Typography style={{ fontSize: 15 }}>
                                        <i>{language == 'en' ? 'Lesson name' : 'Назва вправи'}:</i> {x.name}  &nbsp;&nbsp;&nbsp;   <i>{language == 'en' ? 'Repeat times' : 'Кількість повторювань'} : {x.repeatNumber}</i>  &nbsp;&nbsp;&nbsp;    <i>{language == 'en' ? 'Start bpm' : 'Початковий темп'}:</i> {x.startBpm}  &nbsp;&nbsp;&nbsp;   <i>{language == 'en' ? 'Default step' : 'Рекомендований шаг'}: </i> {x.minTempoStep}
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
                                label={language == 'en' ? "Lesson name" : 'Назва вправи'}
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
                                    label={language == 'en' ? "Select tab" : 'Оберіть табулатуру'}
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
                                label={language == 'en' ? "Number to repeat" : 'Кількість повторювань'}
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
                                label={language == 'en' ? "Start bpm for learning" : 'Початковий темп'}
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
                                label={language == 'en' ? "Step bpm" : 'Шаг темпу'}
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
                            <Button variant="contained" color="primary" type='button' onClick={this.handleAddLessonClickButton} style={{ marginLeft: 5 }}>{language == 'en' ? 'Add' : 'Добавити'}</Button>

                        </Paper>
                        </div>


                        <div className="form-group">
                            <Button variant="contained" color="primary" size='large' type='submit' className="form-group" style={{ margin: 'auto' }}>{language == 'en' ? 'Create' : 'Створити'}</Button>
                        </div>
                    </form>
                </div>
            </Paper>
        );
    }
}

