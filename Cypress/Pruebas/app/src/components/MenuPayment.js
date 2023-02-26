import React, {useEffect, useState, Component} from 'react';
import HeaderUser from './HeaderUser'
import { green } from '@mui/material/colors';
import Button from '@mui/material/Button';
import Box from '@mui/material/Box';
import Cookies from 'universal-cookie'
import Card from '@mui/material/Card';
import CardContent from '@mui/material/CardContent';
import Typography from '@mui/material/Typography';
import ArrowForwardIcon from '@mui/icons-material/ArrowForward';
import PendingActionsIcon from '@mui/icons-material/PendingActions';
import CircularProgress from  '@mui/material/CircularProgress';
import PendingOutlinedIcon from '@mui/icons-material/PendingOutlined';
import LocalAtmOutlinedIcon from '@mui/icons-material/LocalAtmOutlined';
import AccessAlarmOutlinedIcon from '@mui/icons-material/AccessAlarmOutlined';
import RuleOutlinedIcon from '@mui/icons-material/RuleOutlined';
import LibraryAddCheckOutlinedIcon from '@mui/icons-material/LibraryAddCheckOutlined';
import PriceCheckOutlinedIcon from '@mui/icons-material/PriceCheckOutlined';
import PointOfSaleOutlinedIcon from '@mui/icons-material/PointOfSaleOutlined';
import HistoryIcon from '@mui/icons-material/History';
import BallotOutlinedIcon from '@mui/icons-material/BallotOutlined';
import ManageSearchIcon from '@mui/icons-material/ManageSearch';

const cookies = new Cookies();

        const bull = (
            <Box
            component="span"
            sx={{ display: 'inline-block', mx: '2px', transform: 'scale(0.8)' }}
            >
            •
            </Box>
        );

    const MenuPayment = () => {

        const [progress, setProgress] = React.useState(0);

        React.useEffect(() => {
        const timer = setInterval(() => {
            setProgress((prevProgress) => (prevProgress >= 100 ? 0 : prevProgress + 10));
        }, 800);

        return () => {
            clearInterval(timer);
        };
        }, []);

    /*Sesiones*/
    useEffect(() => {
        if (typeof cookies.get('username') === 'undefined' ) {
            window.location.href = "./"
        }
    })

    useEffect(() => {
        if (cookies.get('ownerType') === "admin") {
            window.location.href = "./OwnerController"
        }
    })

    return (
        <div><HeaderUser /><br></br>
        <div className="container item">
            <center><h1>Menu Payments</h1></center><br/>
            <div className="row">
                <div className="col">
                <Card sx={{ maxWidth: 500  } }>
                            <CardContent>
                                <Typography variant="h5" component="div">
                                <PendingActionsIcon fontSize='large'/> Pending Payments:
                                </Typography>
                                <Typography sx={{ mb: 1.5 }} color="text.secondary">
                                
                                </Typography>
                                <Typography variant="body2">
                                </Typography>
                                <Typography sx={{ mb: 1.5 }} color="text.secondary">
                                Here you can see the payments that you have not made yet.
                                </Typography>
                                <div className="row justify-content-center">
                                <div className="col-2 p-1 ">
                                <AccessAlarmOutlinedIcon color="success" fontSize='large' />
                                </div>
                                <div className="col-2 p-1 ">
                                <LocalAtmOutlinedIcon color="success" fontSize='large' />
                                    </div>
                                
                                <div className="col-2 p-1 ">
                                <RuleOutlinedIcon  color="success" fontSize='large' />
                                </div>
                                </div> 
                                <Typography variant="body2">
                                <br/>
                                </Typography>
                                <div className="row justify-content-center">
                                <div className="col-6 ">
                                    <Button className='btn-back' href="/PaymentControllerPending" color='success' variant="contained" endIcon={<ArrowForwardIcon />}>
                                        Check
                                    </Button>
                                    </div>
                                </div>    
                            </CardContent>
                        </Card>        
                </div>
                <div className="col">
                <Card sx={{ maxWidth: 250  } }>
                            <CardContent>
                                <Typography variant="h5" component="div">
                                <PendingOutlinedIcon fontSize='large'/> Payments in process:
                                </Typography>
 
                                <Typography sx={{ mb: 1.5 }} color="text.secondary">
                                
                                </Typography>
                                <Typography variant="body2">
                                </Typography>
                                <Typography sx={{ mb: 1.5 }} color="text.secondary">
                                Payments that have not been confirmed yet, awaiting management approval.
                                </Typography>
                                <div className="row justify-content-center">
                                <div className="col-3 p-2 ">
                                <CircularProgress variant="determinate" color="success" value={progress} />
                                    </div>
                                </div>   
                                <Typography variant="body2">
                                </Typography>
                                <div className="row justify-content-center">
                                <div className="col-6 ">
                                    <Button className='btn-back' href="/PaymentProcessControllerUser" color='success' variant="contained" endIcon={<ArrowForwardIcon />}>
                                        Check
                                    </Button>
                                    </div>
                                </div>    
                            </CardContent>
                        </Card>  
                </div>
                <div className="col">
                <Card sx={{ maxWidth: 250  } }>
                            <CardContent>
                                <Typography variant="h5" component="div">
                                <LibraryAddCheckOutlinedIcon fontSize='large'/>Payments made successfully:
                                </Typography>
 
                                <Typography sx={{ mb: 1.5 }} color="text.secondary">
                                
                                </Typography>
                                <Typography variant="body2">
                                </Typography>
                                <Typography sx={{ mb: 1.5 }} color="text.secondary">
                                Here are the payments that have been confirmed successfully.
                                </Typography>
                                <div className="row justify-content-center">
                                <div className="col-2 p-1 ">
                                <LocalAtmOutlinedIcon color="success" fontSize='large' />
                                </div>
                                <div className="col-2 p-1 ">
                                <PointOfSaleOutlinedIcon color="success" fontSize='large' />
                                    </div>
                                
                                <div className="col-2 p-1 ">
                                <PriceCheckOutlinedIcon  color="success" fontSize='large' />
                                </div>
                                </div> 
                                <Typography variant="body2">
                                <br/>
                                </Typography>
                                <div className="row justify-content-center">
                                <div className="col-6 ">
                                    <Button className='btn-back' href="/PaymentCanceledControllerUser" color='success' variant="contained" endIcon={<ArrowForwardIcon />}>
                                        Check
                                    </Button>
                                    </div>
                                </div>    
                            </CardContent>
                        </Card> 
                </div>
                <div className="col">
                <Card sx={{ maxWidth: 250 } }>
                            <CardContent>
                                <Typography variant="h5" component="div">
                                <ManageSearchIcon fontSize='large'/>Detailed Payment History:
                                </Typography>
 
                                <Typography sx={{ mb: 1.5 }} color="text.secondary">
                                
                                </Typography>
                                <Typography variant="body2">
                                </Typography>
                                <Typography sx={{ mb: 1.5 }} color="text.secondary">
                                Here you can see the history of your payments in detail, you can save a report.
                                </Typography>
                                <div className="row justify-content-center">
                                <div className="col-2 p-1 ">
                                <LocalAtmOutlinedIcon color="success" fontSize='large' />
                                </div>
                                <div className="col-2 p-1 ">
                                <BallotOutlinedIcon color="success" fontSize='large' />
                                    </div>
                                
                                <div className="col-2 p-1 ">
                                < HistoryIcon color="success" fontSize='large' />
                                </div>
                                </div> 
                                <Typography variant="body2">
                                <br/>
                                </Typography>
                                <div className="row justify-content-center">
                                <div className="col-6 ">
                                    <Button className='btn-back' href="/PaymentControllerUser" color='success' variant="contained" endIcon={<ArrowForwardIcon />}>
                                        Check
                                    </Button>
                                    </div>
                                </div>    
                            </CardContent>
                        </Card> 
                </div>
                <div className="col">
                <Card sx={{ maxWidth: 250 } }>
                            <CardContent>
                                <Typography variant="h5" component="div">
                                <ManageSearchIcon fontSize='large'/>Detailed Payment History:
                                </Typography>
 
                                <Typography sx={{ mb: 1.5 }} color="text.secondary">
                                
                                </Typography>
                                <Typography variant="body2">
                                </Typography>
                                <Typography sx={{ mb: 1.5 }} color="text.secondary">
                                Here you can see the history of your payments in detail, you can save a report.
                                </Typography>
                                <div className="row justify-content-center">
                                <div className="col-2 p-1 ">
                                <LocalAtmOutlinedIcon color="success" fontSize='large' />
                                </div>
                                <div className="col-2 p-1 ">
                                <BallotOutlinedIcon color="success" fontSize='large' />
                                    </div>
                                
                                <div className="col-2 p-1 ">
                                < HistoryIcon color="success" fontSize='large' />
                                </div>
                                </div> 
                                <Typography variant="body2">
                                <br/>
                                </Typography>
                                <div className="row justify-content-center">
                                <div className="col-6 ">
                                    <Button className='btn-back' href="/PaymentControllerUser" color='success' variant="contained" endIcon={<ArrowForwardIcon />}>
                                        Check
                                    </Button>
                                    </div>
                                </div>    
                            </CardContent>
                        </Card> 
                </div>
                <div className="col">
                <Card sx={{ maxWidth: 250 } }>
                            <CardContent>
                                <Typography variant="h5" component="div">
                                <ManageSearchIcon fontSize='large'/>Detailed Payment History:
                                </Typography>
 
                                <Typography sx={{ mb: 1.5 }} color="text.secondary">
                                
                                </Typography>
                                <Typography variant="body2">
                                </Typography>
                                <Typography sx={{ mb: 1.5 }} color="text.secondary">
                                Here you can see the history of your payments in detail, you can save a report.
                                </Typography>
                                <div className="row justify-content-center">
                                <div className="col-2 p-1 ">
                                <LocalAtmOutlinedIcon color="success" fontSize='large' />
                                </div>
                                <div className="col-2 p-1 ">
                                <BallotOutlinedIcon color="success" fontSize='large' />
                                    </div>
                                
                                <div className="col-2 p-1 ">
                                < HistoryIcon color="success" fontSize='large' />
                                </div>
                                </div> 
                                <Typography variant="body2">
                                <br/>
                                </Typography>
                                <div className="row justify-content-center">
                                <div className="col-6 ">
                                    <Button className='btn-back' href="/PaymentControllerUser" color='success' variant="contained" endIcon={<ArrowForwardIcon />}>
                                        Check
                                    </Button>
                                    </div>
                                </div>    
                            </CardContent>
                        </Card> 
                </div>
                <div className="col">
                <Card sx={{ maxWidth: 250 } }>
                            <CardContent>
                                <Typography variant="h5" component="div">
                                <ManageSearchIcon fontSize='large'/>Detailed Payment History:
                                </Typography>
 
                                <Typography sx={{ mb: 1.5 }} color="text.secondary">
                                
                                </Typography>
                                <Typography variant="body2">
                                </Typography>
                                <Typography sx={{ mb: 1.5 }} color="text.secondary">
                                Here you can see the history of your payments in detail, you can save a report.
                                </Typography>
                                <div className="row justify-content-center">
                                <div className="col-2 p-1 ">
                                <LocalAtmOutlinedIcon color="success" fontSize='large' />
                                </div>
                                <div className="col-2 p-1 ">
                                <BallotOutlinedIcon color="success" fontSize='large' />
                                    </div>
                                
                                <div className="col-2 p-1 ">
                                < HistoryIcon color="success" fontSize='large' />
                                </div>
                                </div> 
                                <Typography variant="body2">
                                <br/>
                                </Typography>
                                <div className="row justify-content-center">
                                <div className="col-6 ">
                                    <Button className='btn-back' href="/PaymentControllerUser" color='success' variant="contained" endIcon={<ArrowForwardIcon />}>
                                        Check
                                    </Button>
                                    </div>
                                </div>    
                            </CardContent>
                        </Card> 
                </div>
            </div>

         </div>
        </div>
    )
}

export default MenuPayment;