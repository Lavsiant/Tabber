import React from 'react';
import ReactDOM from 'react-dom';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import queryString from 'query-string';
import { Link } from 'react-router-dom';
import { getCourses } from './coursesActions.jsx'
import { withStyles } from '@material-ui/core/styles';
import "isomorphic-fetch";
import Paper from '@material-ui/core/Paper';
import List from '@material-ui/core/List';
import ListItem from '@material-ui/core/ListItem';
import TablePaginationActions from '../common/tablePaginationActions.jsx';
import ListItemIcon from '@material-ui/core/ListItemIcon';
import ListItemText from '@material-ui/core/ListItemText';
import TableHead from '@material-ui/core/TableHead';
import Table from '@material-ui/core/Table';
import TableBody from '@material-ui/core/TableBody';
import TableCell from '@material-ui/core/TableCell';
import TableFooter from '@material-ui/core/TableFooter';
import TablePagination from '@material-ui/core/TablePagination';
import TableRow from '@material-ui/core/TableRow';
import FilterCourseBar from './filterCourseBar.jsx';

class CourseList extends React.Component {
    constructor() {
        super();
        this.state = {
            filteredCourses: [],
            page: 0,
            rowsPerPage: 5
        };
    }

    componentDidMount() {
        this.props.getCourses().then(() =>
            this.setState({ filteredCourses: this.props.courses })
        );

    }

    handleChangePage = (event, page) => {
        this.setState({ page });
    };

    handleChangeRowsPerPage = event => {
        this.setState({ rowsPerPage: +event.target.value });
    };

    filterCourses = (filterOptions) => {
        let courses = this.props.courses;
        console.log(courses);
        if (filterOptions.name)
            courses = courses.filter(x => x.name.toLowerCase().includes(filterOptions.name.toLowerCase()));

        // tabs = !isNaN(filterOptions.minTempo) ? tabs.filter(x=>+x.tempo >= +filterOptions.minTempo) : tabs;
        this.setState({ filteredCourses: courses });
    }

    getTypeString = (x) => {
        let language = '';
        if (localStorage.getItem('lang')) {
            language = localStorage.getItem('lang');
        }
        else {
            language = 'en';
            localStorage.setItem('lang', 'en');
        }
        if (language == 'en') {
            switch (x) {
                case 1: return 'Acoustic Guitar';
                case 2: return 'Electric Guitar';
                case 3: return 'Classical Guitar';
            }
        }
        else{
            switch (x) {
                case 1: return 'Акустична гітара';
                case 2: return 'Електрогітара';
                case 3: return 'Класична гітара';
            }
        }
    }

    render() {

        const { rowsPerPage, page } = this.state;
        const emptyRows = rowsPerPage - Math.min(rowsPerPage, this.state.filteredCourses.length - page * rowsPerPage);
        let language = '';
        if (localStorage.getItem('lang')) {
            language = localStorage.getItem('lang');
        }
        else {
            language = 'en';
            localStorage.setItem('lang', 'en');
        }
        return (
            <Paper className='root'>

                <FilterCourseBar filterCourses={this.filterCourses}></FilterCourseBar>
                <div className='table-wrapper'>
                    <Table className={'table'}>
                        <TableHead>
                            <TableRow>

                                <TableCell style={{ fontSize: 20 }}>{language == 'en' ? 'Name' : 'Назва'}</TableCell>
                                <TableCell style={{ fontSize: 20 }}>{language == 'en' ? 'Type' : 'Тип'}</TableCell>
                                <TableCell style={{ fontSize: 20 }} numeric>{language == 'en' ? 'Creator' : 'Створив'}</TableCell>

                            </TableRow>
                        </TableHead>
                        <TableBody>
                            {this.state.filteredCourses.slice(page * rowsPerPage, page * rowsPerPage + rowsPerPage).map(course => {
                                return (
                                    <TableRow key={course.id} className="table-field" component={Link} to={'/course/' + course.id}>
                                        <TableCell style={{ fontSize: 18 }} component="th" scope="row" >
                                            {course.name}
                                        </TableCell>
                                        <TableCell style={{ fontSize: 18 }} component="th" scope="row" >
                                            {this.getTypeString(course.type)}
                                        </TableCell>
                                        <TableCell style={{ fontSize: 18 }} component="th" scope="row" numeric>{course.creator}</TableCell>
                                    </TableRow>
                                );
                            })}
                            {emptyRows > 0 && (
                                <TableRow style={{ height: 48 * emptyRows }}>
                                    <TableCell colSpan={6} />
                                </TableRow>
                            )}
                        </TableBody>
                        <TableFooter>
                            <TableRow>
                                <TablePagination
                                    rowsPerPageOptions={[2, 5, 10, 25]}
                                    colSpan={3}
                                    count={this.props.courses.length}
                                    rowsPerPage={rowsPerPage}
                                    page={page}
                                    SelectProps={{
                                        native: true,
                                    }}
                                    onChangePage={this.handleChangePage}
                                    onChangeRowsPerPage={this.handleChangeRowsPerPage}
                                    ActionsComponent={TablePaginationActions}
                                />
                            </TableRow>
                        </TableFooter>
                    </Table>
                </div>
            </Paper>
        );
    }
};

let mapProps = (state) => {
    return {
        courses: state.coursesReducer.courses,
        error: state.coursesReducer.error
    }
}

let mapDispatch = (dispatch) => {
    return {
        getCourses: bindActionCreators(getCourses, dispatch),
    }
}

export default connect(mapProps, mapDispatch)(CourseList) 