import React from 'react';
import ReactDOM from 'react-dom';
import TextField from '@material-ui/core/TextField';
import AddIcon from '@material-ui/icons/Add';
import Fab from '@material-ui/core/Fab';

export default class FilterTabBar extends React.Component {
    constructor() {
        super();
        this.state = {
            name: '',
            minTempo: '',
            maxTempo: ''
        };
    }

    onNameChanged = e => {
       
        this.setState({ name: e.target.value });
        this.state.name = e.target.value;
        this.props.filterTabs({name: e.target.value, maxTempo: this.state.maxTempo, minTempo: this.state.minTempo});
    }

    onMinTempoChanged = e => {
        this.setState({ minTempo: e.target.value });
        this.props.filterTabs({name: this.state.name, maxTempo: this.state.maxTempo, minTempo: e.target.value});
    }

    onMaxTempoChanged = e => {
        this.setState({ maxTempo: e.target.value });
        this.props.filterTabs({name: this.state.name, maxTempo: e.target.value, minTempo: this.state.minTempo});
    }

    createTabOpen = () => {
        window.location = config.apiUrl + "/course-create";
    }

    render() {
        let language = '';
        if(localStorage.getItem('lang')){
            language = localStorage.getItem('lang');
        }
        else{
            language = 'en';
            localStorage.setItem('lang', 'en');
        }
        return (
            <div className="filter-bar" style={{width:'100%'}}>
                <div className="filter">
                    <TextField 
                        className="filter-field"
                        label={language == 'en' ? "Tab name" : 'Назва табулатури'}
                        margin="normal"
                        variant="outlined"
                        onChange={this.onNameChanged}
                    />
                </div>
                <div className="filter">
                    <TextField                   
                        label={language == 'en' ? "Min tempo" : 'Мінімальний темп'}
                        defaultValue=""
                        type="number"
                        className="filter-field"
                        margin="normal"
                        variant="outlined"
                        onChange={this.onMinTempoChanged}
                    />
                </div>
                <div className="filter">
                    <TextField
                        className="filter-field"
                        label={language == 'en' ? "Max tempo" : 'Максимальний темп'}
                        type="number"
                        margin="normal"
                        variant="outlined"
                        onChange={this.onMaxTempoChanged}
                    />
                </div>
                <div className="filter" style={{float: 'right', paddingTop: 16}}>
                <Fab size="large" color="primary" to='/tab-create' style={{float:'right'}} aria-label="Add" onClick={this.props.createTabOpen}>
                    <AddIcon />
                </Fab>
                </div>
            </div>
        );
    }
}